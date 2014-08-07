using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACRM.RAM
{
    class ApplicationIdleTimer
    {
        #region Static Members and Events
	
		// private singleton
		private static ApplicationIdleTimer instance = null;
	
		// Notes:
		// Could have utilized the System.Timers.ElapsedEventArgs, but that 
		// only provides the time an event happend (even though it's called
		// "Elapsed" not "Timed" EventArgs).  I figgure most listeners care
		// less *WHEN* the app went idle, but rather *HOW LONG* it has been 
		// idle.
		
		/// <summary>
		/// EventArgs for an ApplicationIdle event.
		/// </summary>
		public class ApplicationIdleEventArgs : EventArgs
		{
			// time of last idle
			private DateTime _idleSince;
			// duration of "idleness"
			private TimeSpan _idleTime;
			
			/// <summary>
			/// Internal constructor
			/// </summary>
			/// <param name="idleSince">Time app was declared idle</param>
			internal ApplicationIdleEventArgs(DateTime idleSince) : base()
			{
				_idleSince = idleSince;
				_idleTime = new TimeSpan(DateTime.Now.Ticks - idleSince.Ticks);
			}
			
			/// <summary>
			/// Timestamp of the last time the application was "active".
			/// </summary>
			public DateTime IdleSince
			{
				get { return _idleSince; }
			}
			
			/// <summary>
			/// Duration of time the application has been idle.
			/// </summary>
			public TimeSpan IdleDuration
			{
				get { return _idleTime; }
			}
		}
		/// <summary>
		/// ApplicationIdle event handler.
		/// </summary>
		public delegate void ApplicationIdleEventHandler( ApplicationIdleEventArgs e );
		
		/// <summary>
		/// Hook into the ApplicationIdle event to monitor inactivity.
		/// It will fire AT MOST once per second.
		/// </summary>
		public static event ApplicationIdleEventHandler ApplicationIdle;
	#endregion
	
	#region Private Members
		// Timer used to guarentee perodic updates.
		private System.Timers.Timer _timer; 

		// Tracks idle state
		private bool isIdle;
		// Last time application was declared "idle"
		private System.DateTime lastAppIdleTime;
		// Last time we checked for GUI activity
		private long lastIdleCheckpoint;
		// Running count of Application.Idle events recorded since a checkpoint.
		// Expressed as a long (instead of int) for math.
		private long idlesSinceCheckpoint;
		// Number of ticks used by application process at last checkpoint
		private long cpuTime;
		// Last time we checked for cpu activity
		private long lastCpuCheckpoint;		
		
		// These values can be adjusted through the static properties:
		// Maximum "activity" (Application.Idle events per second) that will be considered "idle"
		// Here it is expressed as minimum ticks between idles.
		private long guiThreshold = TimeSpan.TicksPerMillisecond * 50L; 
		// Maximum CPU use (percentage) that is considered "idle"
		private double cpuThreshold = 0.05;
	#endregion

	#region Constructors
		/// <summary>
		/// Private constructor.  One instance is plenty.
		/// </summary> 
		private ApplicationIdleTimer()
		{
			// Initialize counters
			isIdle = false;
			lastAppIdleTime = DateTime.Now;
			lastIdleCheckpoint = lastCpuCheckpoint = DateTime.UtcNow.Ticks;
			idlesSinceCheckpoint = cpuTime = 0;

			// Set up the timer and the counters
			_timer = new System.Timers.Timer(500); // every half-second.
			_timer.Enabled = true;
			_timer.Start();
			
			// Hook into the events
			_timer.Elapsed += new System.Timers.ElapsedEventHandler(Heartbeat);
			System.Windows.Forms.Application.Idle += new EventHandler(Application_Idle);
		}
		/// <summary>
		/// Static initialization.  Called once per AppDomain.
		/// </summary>
		static ApplicationIdleTimer()
		{
			// Create the singleton.
			if (instance==null)
			{
				instance = new ApplicationIdleTimer();
			}
		}
	#endregion

	#region Private Methods

		private void Heartbeat(object sender, System.Timers.ElapsedEventArgs e)
		{
			// First we need to do here is compensate for the
			// "heartbeat", since it will result in an 'extra'
			// Idle firing .. just don't cause a divide by zero!
			if (idlesSinceCheckpoint>1)
				idlesSinceCheckpoint--;

			bool newIdle = isIdle;
			long delta = DateTime.UtcNow.Ticks - lastIdleCheckpoint;

			// Determine average idle events per second.  Done manually here
			// instead of using the ComputeGUIActivity() method to avoid the 
			// unnecessary numeric conversion and use of a TimeSpan object.
			if (delta >= TimeSpan.TicksPerSecond) 
			{
				// It's been over a second since last checkpoint, 
				// so determine how "busy" the app has been over that timeframe.
				if (idlesSinceCheckpoint == 0 || delta / idlesSinceCheckpoint >= guiThreshold) 
				{
					// Minimal gui activity.  Check recent CPU activity.
					if (cpuThreshold < 1.0)
						newIdle = (ComputeCPUUsage(true) < cpuThreshold);
					else
						newIdle = true;
				}
				else
				{
					newIdle = false;
				}
				
				// Update counters if state changed.
				if (newIdle != isIdle)
				{
					isIdle = newIdle;
					if (newIdle)
						lastAppIdleTime = DateTime.Now.AddTicks(-1L * delta);
				}
				
				// Reset checkpoint.
				lastIdleCheckpoint = DateTime.UtcNow.Ticks;
				idlesSinceCheckpoint = 0;

				// Last but not least, if idle, raise the event.
				if (newIdle) 
					OnApplicationIdle();
			}
		}
		private void Application_Idle(object sender, EventArgs e)
		{
			// Increment idle counter.
			idlesSinceCheckpoint++;
		}
		
		internal double ComputeCPUUsage(bool resetCounters)
		{
			long delta = DateTime.UtcNow.Ticks - lastCpuCheckpoint;
			double pctUse = 0.0;
			try
			{
				// Get total time this process has used the cpu.
				long cpu = System.Diagnostics.Process.GetCurrentProcess().TotalProcessorTime.Ticks;
				
				// Compute usage.
				if (delta > 0)
					pctUse = ((double)(cpu - cpuTime)) / (double)delta;
				else
					pctUse = ((cpu - cpuTime) == 0 ? 0.0 : 1.0);
				
				// Update counter and checkpoint if told OR if delta is at least a quarter second.
				// This is to prevent inaccurate readings due to frequent OR infrequent calls.
				if (resetCounters || 4L * delta >= TimeSpan.TicksPerSecond)
				{
					lastCpuCheckpoint = DateTime.UtcNow.Ticks;
					cpuTime = cpu;

					// Update idle status if above threshold.
					if (!resetCounters && isIdle && pctUse > cpuThreshold)
						isIdle = false;
				}
			}
			catch (Exception)
			{
				// Probably a security thing.  Just ignore.
				pctUse = double.NaN;
			}
			return pctUse;
		}
		
		internal double ComputeGUIActivity()
		{
			if (idlesSinceCheckpoint<=0) return 0.0;

			TimeSpan delta = new TimeSpan(DateTime.UtcNow.Ticks - lastIdleCheckpoint);
			if (delta.Ticks == 0)
			{
				// Clock hasn't updated yet.  Return a "real" value
				// based on counter (either 0 or twice the threshold).
				return (idlesSinceCheckpoint==0 ? 0.0 : ((double)TimeSpan.TicksPerSecond / (double)instance.guiThreshold) * 2.0);
			}

			// Expressed as activity (number of idles) per second.
			return ((double)idlesSinceCheckpoint / delta.TotalSeconds);
			
			// Note that this method, unlike his CPU brother, does not reset any counters.
			// The gui activity counters are reset once a second by the Heartbeat.
		}
		private void OnApplicationIdle()
		{
			// Check to see if anyone cares.
			if (ApplicationIdle == null) return;
			
			// Build the message
			ApplicationIdleEventArgs e = new ApplicationIdleEventArgs(this.lastAppIdleTime);
						
			// Iterate over all listeners
			foreach( MulticastDelegate multicast in ApplicationIdle.GetInvocationList() )
			{
				// Raise the event
				multicast.DynamicInvoke( new object[] { e } );
			}
		}
	#endregion
	
	#region Static Properties
		/// <summary>
		/// Returns the percent CPU use for the current process (0.0-1.0).
		/// Will return double.NaN if indeterminate.
		/// </summary>
		public static double CurrentCPUUsage
		{
			get { return instance.ComputeCPUUsage(false); }
		}
		
		/// <summary>
		/// Returns an "indication" of the gui activity, expressed as 
		/// activity per second.  0 indicates no activity.
		/// GUI activity includes user interactions (typing, 
		/// moving mouse) as well as events, paint operations, etc.
		/// </summary>
		public static double CurrentGUIActivity
		{
			get { return instance.ComputeGUIActivity(); }
		}
		
		/// <summary>
		/// Returns the *last determined* idle state.  Idle state is 
		/// recomputed once per second.  Both the gui and the cpu must
		/// be idle for this property to be true.
		/// </summary>
		public static bool IsIdle
		{
			get { return instance.isIdle; }
		}
		
		/// <summary>
		/// The threshold (gui activity) for determining idleness.
		/// GUI activity below this level is considered "idle".
		/// </summary>
		public static double GUIActivityThreshold
		{
			get 
			{	
				return ((double)TimeSpan.TicksPerSecond / (double)instance.guiThreshold); 
			}
			set 
			{   
				// validate value
				if (value <= 0.0)
					throw new ArgumentOutOfRangeException("GUIActivityThreshold", value, "GUIActivityThreshold must be greater than zero.");
				
				instance.guiThreshold = (long)((double)TimeSpan.TicksPerSecond / value);
			}
		}
		
		/// <summary>
		/// The threshold (cpu usage) for determining idleness.
		/// CPU usage below this level is considered "idle".
		/// A value >= 1.0 will disable CPU idle checking.
		/// </summary>
		public static double CPUUsageThreshold
		{
			get { return instance.cpuThreshold; }
			set 
			{ 
				if (value == instance.cpuThreshold)
					return;
					
				// validate value
				if (value < 0.0)
					throw new ArgumentOutOfRangeException("CPUUsageThreshold", value, "Negative values are not allowed.");
					
				instance.cpuThreshold = value;
			}
		}
	#endregion
	}
    }







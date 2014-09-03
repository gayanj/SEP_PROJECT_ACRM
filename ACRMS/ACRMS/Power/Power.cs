using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEPMetro
{
    public partial class Power : Form
    {
        Timer t;
   
        public Power()
        {
            InitializeComponent();
        }

        private void Power_Load(object sender, EventArgs e)
        {
            t = new Timer { Enabled = true, Interval = 1000 };
            t.Tick += t_Tick;
            powerName.TextChanged += new EventHandler(this.t_Tick);
   
        }

        void t_Tick(object sender, EventArgs e)
        {
            ManagementScope scope = new ManagementScope("\\\\.\\ROOT\\CIMV2\\power");

            //create object query
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_PowerMeter");

            //create object searcher
            ManagementObjectSearcher searcher =
                                    new ManagementObjectSearcher(scope, query);

            //get collection of WMI objects
           // ManagementObjectCollection queryCollection = searcher.Get();
            ManagementObjectCollection queryCollection = searcher.Get();
            Debug.Assert(queryCollection.Count > 0, "queryCollection.Count > 0", "Can't find any instance.");

            //enumerate the collection.
            foreach (ManagementObject m in queryCollection)
            {
                try
                {
                    // access properties of the WMI object
                  

                    powerName.Text = m["Name"].ToString();
                    powerDeviceId.Text = (m["DeviceID"]).ToString();
                    powerSupportCapabilities.Text = m["DeviceID"].ToString();
                    powerMeterType.Text = m["MeterType"].ToString();
                    powerSamplingPeriod.Text = m["SamplingPeriod"].ToString();
                    powerMinAvg.Text = m["MinimumAveragingInterval"].ToString();
                    powerMaxAvg.Text = m["MaximumAveragingInterval"].ToString();
                    powerAvg.Text = m["AveragingInterval"].ToString();
                    powerMinOperating.Text = m["MinOperatingBudget"].ToString();
                    powerMaxOperating.Text = m["MaxOperatingBudget"].ToString();
                    powerBudgetWriteable.Text = m["BudgetWriteable"].ToString();
                    powerBudgetEnabled.Text = m["BudgetEnabled"].ToString();
                    powerConfigureBudget.Text = m["ConfiguredBudget"].ToString();
                    powerBaseUnits.Text = m["BaseUnits"].ToString();
                    powerUnitModifier.Text = m["UnitModifier"].ToString();
                    powerHysteresis.Text = m["Hysteresis"].ToString();
                }
                catch (Exception ex)
                {
                    //powerName.Text = "Not available";
                    //powerDeviceId.Text = "Not available";
                    //powerSupportCapabilities.Text = "Not available";
                    //powerMeterType.Text = "Not available";
                    //powerSamplingPeriod.Text = "Not available";
                    //powerMinAvg.Text = "Not available";
                    //powerMaxAvg.Text = "Not available";
                    //powerAvg.Text = "Not available";
                    //powerMinOperating.Text = "Not available";
                    //powerMaxOperating.Text = "Not available";
                    //powerBudgetWriteable.Text = "Not available";
                    //powerBudgetEnabled.Text = "Not available";
                    //powerConfigureBudget.Text = "Not available";
                    //powerBaseUnits.Text = "Not available";
                    //powerUnitModifier.Text = "Not available";
                    //powerHysteresis.Text = "Not available";
                }

            }
        }
	
    }
}

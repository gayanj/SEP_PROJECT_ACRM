using System;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;

using ACRMS.DISK.DiskDataHandler;
using ACRMS.DISK.DiskMonitorBundle;

namespace ACRMS.WCF
{
	using System.ServiceModel.Activation;

	using ACRMS.RAM;

	public partial class WcfForm : Form
    {
        private ServiceHost Host;
		private WebServiceHost webHost;

        public WcfForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
			webHost = new WebServiceHost(typeof(DiskWcfSimpleService), new Uri("http://localhost:8001/acrmswcfdisk"));
            try{
                webHost.Open();
	            MessageBox.Show("WCF Service Open", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (CommunicationException commProblem){
	            MessageBox.Show("Communication Problem Occured", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            webHost.Close();
	        MessageBox.Show("WCF Service Terminated", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    [ServiceContract]
    public interface IDiskWcfSimpleService
    {
		[OperationContract]
		[WebGet(UriTemplate = "/Ready",
			RequestFormat = WebMessageFormat.Json)]
		string ready();

        [OperationContract]
		[WebGet(UriTemplate = "/GetDiskDataValues/{hostName}",
			RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
        DiskDataValues GetDiskDataValues(string hostName);
    }

	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class DiskWcfSimpleService : IDiskWcfSimpleService
	{
		private PerfCounterHD perf;

		public string ready()
		{
			if (perf == null){
				perf = new PerfCounterHD(Environment.MachineName);
				return "ready";
			}
			else{
				return "Existing";
			}
		}
		public DiskDataValues GetDiskDataValues(string hostName)
        {
			if (hostName == ""){
				hostName = "ARGOS";
			}

            DiskDataValues diskData = perf.GetValues();
            return diskData;
        }
    }
}

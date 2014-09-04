using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;

using ACRMS.DISK.DiskDataHandler;
using ACRMS.DISK.DiskMonitorBundle;

namespace ACRMS.WCF
{
    public partial class WcfForm : Form
    {
        private ServiceHost Host;

        public WcfForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(SimpleService), new Uri("http://localhost:8001/MetadataSample"));

            try{
                // Check to see if the service host already has a ServiceMetadataBehavior
                ServiceMetadataBehavior smb = Host.Description.Behaviors.Find<ServiceMetadataBehavior>();
                // If not, add one
                if (smb == null) smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                Host.Description.Behaviors.Add(smb);
                // Add MEX endpoint
                Host.AddServiceEndpoint(
                    ServiceMetadataBehavior.MexContractName,
                    MetadataExchangeBindings.CreateMexHttpBinding(),
                    "mex");
                // Add application endpoint
                Host.AddServiceEndpoint(typeof(ISimpleService), new WSHttpBinding(), "");

                // Open the service host to accept incoming calls
                Host.Open();

                // The service can now be accessed.
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();

                // Close the ServiceHostBase to shutdown the service.
                //host.Close();
            }
            catch (CommunicationException commProblem){
                Console.WriteLine("There was a communication problem. " + commProblem.Message);
                Console.Read();
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Host.Close();
        }
    }

    [ServiceContract]
    public interface ISimpleService
    {
        [OperationContract]
        string Test();

        [OperationContract]
        DiskDataValues GetObject(string hostName);
    }

    public class SimpleService : ISimpleService
    {
        #region Implementation of ISimpleService

        public string Test()
        {
            return "Hello world";
        }

        public DiskDataValues GetObject(string hostName)
        {
            PerfCounterHD perf = new PerfCounterHD(hostName);
            DiskDataValues diskData = perf.GetValues();
            return diskData;
        }

        #endregion
    }
}
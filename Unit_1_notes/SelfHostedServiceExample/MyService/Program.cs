using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace MyService
{
    [ServiceContract]
    public interface MyInterface
    {
        [OperationContract]
        double PiValue();
        [OperationContract]
        int AbsValue(int value);
    }

    public class MyService : MyInterface
    {
        public double PiValue()
        {
            return System.Math.PI;
        }

        public int AbsValue(int value)
        {
            if (value >= 0)
            {
                return value;
            }
            else
            {
                return -value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Add address and binding
            Uri baseAddress = new Uri("http://localhost:8000/Service");
            ServiceHost selfHost = new ServiceHost(typeof(MyService), baseAddress);

            // Add contract
            try
            {
                selfHost.AddServiceEndpoint(typeof(MyInterface), new WSHttpBinding(), "MyService");

                // Add metadata for public access
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                // Start the service, wait for request
                selfHost.Open();

                // Inform the user
                Console.WriteLine("MyService which is developed in WCF is ready to take requests. Please create a client to call one of the services built into it.");
                Console.WriteLine("If you want to quit this service, simply press <ENTER>.\n");
                Console.ReadLine();

                // Close the service to shutdown the services
                selfHost.Close();
            }
            catch
            {

            }
        }
    }
}

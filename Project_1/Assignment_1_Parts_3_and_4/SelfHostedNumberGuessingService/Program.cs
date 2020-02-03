using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace SelfHostedNumberGuessingService
{
    [ServiceContract]
    public interface GuessingServiceInterface
    {
        [OperationContract]
        int SecretNumber(int lower, int upper);
        [OperationContract]
        string CheckNumber(int userNumber, int secretNumber);
    }

    public class GuessingService : GuessingServiceInterface
    {
        /// <summary>
        /// Generates a secret number between the bounds specified.
        /// </summary>
        /// <param name="lower">
        /// The lower bound for the secret number.
        /// </param>
        /// <param name="upper">
        /// The upper bound for the secret number.
        /// </param>
        /// <returns>A randomly generated integer between the bounds specified.
        /// </returns>
        /// <remarks>
        /// The logic of this method was provided in the assignment description
        /// provided by ASU written by Dr. Yinong Chen.
        /// </remarks>
        public int SecretNumber(int lower, int upper)
        {
            DateTime currentDate = DateTime.Now;
            int seed = (int)currentDate.Ticks;
            Random random = new Random(seed);
            int sNumber = random.Next(lower, upper);
            return sNumber;
        }

        /// <summary>
        /// Compares the two numbers passed.
        /// </summary>
        /// <param name="userNumber">
        /// The first number to compare, usually the user's guess of the secret number.
        /// </param>
        /// <param name="secretNumber">
        /// The second number to compare, usually the current secret number.
        /// </param>
        /// <returns>
        /// Returns a string based upon the comparision of the two numbers.
        /// "Correct" - Indicates that the numbers match.
        /// "Too big" - Indicates that the userNumber is larger than the secret number.
        /// "Too small" - Indicates that the userNumber is smaller than the secret number.
        /// </returns>
        /// <remarks>
        /// The logic of this method was provided in the assignment description
        /// provided by ASU written by Dr. Yinong Chen.
        /// </remarks>
        public string CheckNumber(int userNumber, int secretNumber)
        {
            if(userNumber == secretNumber)
            {
                return "Correct";
            }
            else
            {
                if(userNumber > secretNumber)
                {
                    return "Too big";
                }
                else
                {
                    return "Too small";
                }
            }
        }
    }

    class ServiceHostGeneration
    {
        /// <summary>
        /// Builds the service hosted at the address provided within the code.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Add address and binding
            Uri baseAddress = new Uri("http://localhost:8000/Service");
            ServiceHost selfHost = new ServiceHost(typeof(GuessingService), baseAddress);
            // Add contract
            try
            {
                selfHost.AddServiceEndpoint(typeof(GuessingServiceInterface), new WSHttpBinding(), "GuessingService");

                // Add metadata for public access
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                // Start the service, wait for request
                selfHost.Open();

                // Inform the user
                Console.WriteLine("GuessingService which is developed in WCF is ready to take requests. Please create a client to call one of the services built into it.\n");
                Console.WriteLine("If you want to quit this service, simply press <ENTER>.\n");
                Console.ReadLine();

                // Close the service to shutdown the services
                selfHost.Close();
            }
            catch(CommunicationException ce)
            {
                Console.WriteLine(ce.Message);
                selfHost.Abort();
            }
        }
    }
}

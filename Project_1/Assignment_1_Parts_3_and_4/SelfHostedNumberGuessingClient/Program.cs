using System;
using System.ServiceModel;

namespace SelfHostedNumberGuessingClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the self hosted service
            GuessingServiceInterfaceClient guessingServiceProxy = new GuessingServiceInterfaceClient();
            guessingServiceProxy.Open();
            // Generate a secret number
            int lower = 1;
            int upper = 5;
            int secretNumber = guessingServiceProxy.SecretNumber(lower, upper);
            Console.WriteLine($"Generated a secret number between {lower} and {upper} with a value of {secretNumber}");
            // Guess the secret number
            int mid = (upper + lower) / 2;
            Console.WriteLine($"Guessing {mid}, with a result of \"{guessingServiceProxy.CheckNumber(mid, secretNumber)}\"");
            // Close the service connection
            guessingServiceProxy.Close();
        }
    }
}

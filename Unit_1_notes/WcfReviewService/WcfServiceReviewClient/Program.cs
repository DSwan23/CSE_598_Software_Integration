using System;

namespace WcfServiceReviewClient
{
    class Program
    {
        static void Main(string[] args)
        {
            myServiceRef.ServiceClient myProxy = new myServiceRef.ServiceClient();
            // Get the pi value from the service
            double pi = myProxy.PiValue();
            Int32 test1 = 27;
            Int32 test2 = -132;
            Int32 result1 = myProxy.AbsValue(test1);
            Int32 result2 = myProxy.AbsValue(test2);
            Console.WriteLine($"Pi Value = {pi}");
            Console.WriteLine($"Absolute Values of {test1} is {result1} and of {test2} is {result2}");
            Console.WriteLine($"GetData = {myProxy.GetData(1234)}");
            // Close the proxy channel to the service
        }
    }
}

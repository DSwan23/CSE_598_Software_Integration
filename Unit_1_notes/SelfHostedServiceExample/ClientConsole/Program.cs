using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a proxy to the WCF service
            MyInterfaceClient myProxy = new MyInterfaceClient();
            // Call the service operations through the proxy
            double pi = myProxy.PiValue();
            Int32 test1 = 27;
            Int32 test2 = -132;
            Int32 result1 = myProxy.AbsValue(test1);
            Int32 result2 = myProxy.AbsValue(test2);
            Console.WriteLine($"PI values = {pi}");
            Console.WriteLine($"Abs Values of {test1} is {result1} and {test2} is {result2}");
            myProxy.Close();
            Console.WriteLine("/n Press <ENTER> to terminate the client!./n");
        }
    }
}

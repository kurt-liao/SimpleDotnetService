using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using HelloWorldService;

namespace HostService
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = new ServiceHost(typeof(HelloWorld),  new Uri("net.pipe://localhost/"));
            h.AddServiceEndpoint(typeof(IHelloWorld), new NetNamedPipeBinding(), "HelloService");
            h.Open();

            Console.WriteLine("Start Hello Service");
            Console.WriteLine("Press enter to stop service");
            Console.ReadLine();

            h.Close();
        }
    }
}

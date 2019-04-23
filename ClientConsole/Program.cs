using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using HelloWorldService;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input == "1")
            {
                OpenChannel();
                input = Console.ReadLine();
            }
        }

        public static void OpenChannel()
        {
            using (ChannelFactory<IHelloWorld> channel = new ChannelFactory<IHelloWorld>(new NetTcpBinding(), new EndpointAddress("net.tcp://localhost:8005/HelloService")))
            {
                IHelloWorld client = channel.CreateChannel();//CreateChannel後就會Open Channel

                Console.WriteLine(client.Hello());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using HelloWorldService;

namespace ClientConsole
{
    public class HelloWorldClien : ClientBase<IHelloWorld>
    {
        public HelloWorldClien(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress)
            : base(binding, remoteAddress)
        {

        }

        public string HelloWorld()
        {
            return base.Channel.Hello();
        }
    }
}

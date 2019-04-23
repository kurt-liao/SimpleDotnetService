using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HelloWorldService
{
    public class HelloWorld : IHelloWorld
    {
        public string Hello()
        {
            return "Hello World";
        }
    }
}

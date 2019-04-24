using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.ServiceModel;
using HelloWorldService;

namespace HelloAutoService
{
    public partial class Service1 : ServiceBase
    {
        private ServiceHost _host;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _host = new ServiceHost(typeof(HelloWorld), new Uri("net.pipe://localhost/"));
            _host.AddServiceEndpoint(typeof(IHelloWorld), new NetNamedPipeBinding(), "HelloService");
            _host.Open();
        }

        protected override void OnStop()
        {
            _host = null;
        }
    }
}

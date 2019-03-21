using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace httpServerServiceV2
{
    public partial class WebServerService : ServiceBase
    {

        public WebServerService()
        {
            InitializeComponent();
            Server server = new Server();
            server.StartServer();
        }

        protected override void OnStart(string[] args)
        {

        }

        protected override void OnStop()
        {
        }
    }
}

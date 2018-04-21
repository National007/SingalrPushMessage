using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Ahoo.Demo.RuntimePush.App_Start.Startup))]

namespace Ahoo.Demo.RuntimePush.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.MapHubs();
            // 有关如何配置应用程序的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}

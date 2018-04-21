using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace Ahoo.Demo.RuntimePush.Hubs
{
    public class PushHub : Hub
    {
        public static void SendMessage(string msg)
        {
            //调用 Signlar集线器类
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<PushHub>();
            // 调用所有客户端的notice方法
            context.Clients.All.notice(msg);
        }
    }
}
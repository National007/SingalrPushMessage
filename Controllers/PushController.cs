using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ahoo.Demo.RuntimePush.Hubs;
using Microsoft.AspNet.SignalR;
using Ahoo.Demo.RuntimePush.ViewModels;
using Ahoo.Demo.RuntimePush;

namespace Ahoo.Demo.RuntimePush.Controllers
{
    public class PushController : Controller
    {
        //
        // GET: /Push/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Push(string msg)
        {
            AjaxResult result = new AjaxResult();
            try
            {
                PushHub.SendMessage(msg);
                result.Message = "广播成功!";
            }
            catch (Exception e)
            {
                result.IsSuccess = false;
                result.Message = "广播失败!";
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}

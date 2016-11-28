using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {

        }
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var da = filterContext.HttpContext.Request.Headers["ApiKey"];
        }
    }
}
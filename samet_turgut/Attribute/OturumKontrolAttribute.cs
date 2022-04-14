using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace samet_turgut.Attribute
{
    public class OturumKontrolAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var cerez = filterContext.HttpContext.Request.Cookies["Oturum"];

            if (cerez == null)
            {
                filterContext.HttpContext.Response.Redirect("/Oturum/OturumAc");
            }
            else
            {
                FormsAuthenticationTicket bilet = FormsAuthentication.Decrypt(cerez.Value);
                if (bilet.Expired == true)
                {
                    filterContext.HttpContext.Response.Redirect("/Oturum/OturumAc");
                }
            }
        }
    }
}
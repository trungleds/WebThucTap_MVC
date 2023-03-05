using System.Web.Mvc;

namespace WebLtic.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", controller = "Home", id = UrlParameter.Optional },
                 new[] { "WebLtic.Areas.Admin.Controllers" }
            );
        }
    }
}
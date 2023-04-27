using System.Web.Mvc;

namespace Nhom18_TTCM_CNTTVA1_K61.Areas.Admin
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
                new { action = "Index", id = UrlParameter.Optional },
                new[] { "Nhom18_TTCM_CNTTVA1_K61.Areas.Admin.Controllers" }
            );
        }
    }
}
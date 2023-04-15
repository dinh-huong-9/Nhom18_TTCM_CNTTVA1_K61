using System.Web;
using System.Web.Mvc;

namespace Nhom18_TTCM_CNTTVA1_K61
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

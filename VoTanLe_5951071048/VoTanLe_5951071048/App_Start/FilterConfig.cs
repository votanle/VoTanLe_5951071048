using System.Web;
using System.Web.Mvc;

namespace VoTanLe_5951071048
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

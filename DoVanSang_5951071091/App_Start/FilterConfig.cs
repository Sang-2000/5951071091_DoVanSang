using System.Web;
using System.Web.Mvc;

namespace DoVanSang_5951071091
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

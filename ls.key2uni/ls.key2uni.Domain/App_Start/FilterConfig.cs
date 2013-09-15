using System.Web;
using System.Web.Mvc;

namespace ls.key2uni.Domain
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
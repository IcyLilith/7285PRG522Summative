using System.Web;
using System.Web.Mvc;

namespace PRG522_SA_7285
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

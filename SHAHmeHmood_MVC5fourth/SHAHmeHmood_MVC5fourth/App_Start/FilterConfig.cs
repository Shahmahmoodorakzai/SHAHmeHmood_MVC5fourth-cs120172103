using System.Web;
using System.Web.Mvc;

namespace SHAHmeHmood_MVC5fourth
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

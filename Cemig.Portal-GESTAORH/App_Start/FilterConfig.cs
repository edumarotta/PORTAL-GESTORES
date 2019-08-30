using System.Web;
using System.Web.Mvc;

namespace Cemig.Portal_GESTAORH
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

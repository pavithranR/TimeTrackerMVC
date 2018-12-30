using System.Web;
using System.Web.Mvc;
using TimeTracker.Helpers;

namespace TimeTracker
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new ErrorLoggerAttribute());
        }
    }
}

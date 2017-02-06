using System.Web;
using System.Web.Mvc;

namespace Mental_Capacity_Assessments
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

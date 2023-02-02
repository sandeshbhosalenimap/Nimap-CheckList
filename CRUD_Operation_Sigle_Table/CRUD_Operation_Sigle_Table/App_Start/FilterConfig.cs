using System.Web;
using System.Web.Mvc;

namespace CRUD_Operation_Sigle_Table
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

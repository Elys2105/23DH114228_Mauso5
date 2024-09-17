using System.Web;
using System.Web.Mvc;

namespace _23DH114228_Mauso5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

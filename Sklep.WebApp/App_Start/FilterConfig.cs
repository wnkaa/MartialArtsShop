
using System.Web.Mvc;

namespace Sklep.WebApp.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
          //  filters.Add(new AuthorizeAttribute()); // its securing application by default. So we need to be logged in to see content not marked with alloAnnonymous
        }
    }
}
using System.Web;
using System.Web.Mvc;

namespace SkillsProfileProject_MVC_EntityFramework
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

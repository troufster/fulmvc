using System.Web.Mvc;

namespace fulmvc.Areas.Majorbyte
{
    public class MajorbyteAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Majorbyte";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Majorbyte_default",
                "Majorbyte/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new string[]{"fulmvc.Areas.Majorbyte.Controllers"}
            );
        }
    }
}

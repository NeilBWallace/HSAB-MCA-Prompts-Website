using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mental_Capacity_Assessments.Startup))]
namespace Mental_Capacity_Assessments
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            Globals.Current_Page = "1";
            @Globals.Section = "";
            @Globals.Disclaimer = "message";
            Globals.FirstTime = "1";
        }
    }
}

using System.Web.Mvc;
using System.Web.Routing;
using DataAccess.Repository;

namespace BankSystem
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var context = new BankSystemDbContext();
            context.Database.CreateIfNotExists();
        }
    }
}

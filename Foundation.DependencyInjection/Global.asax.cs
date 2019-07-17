using Autofac;
using System.Web.Mvc;
using Foundation.DependencyInjection.Configurators;
using Autofac.Integration.Mvc;

namespace Foundation.DependencyInjection
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var builder = new ContainerBuilder();
            DIConfigurator.ConfigureContainer(builder);
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}

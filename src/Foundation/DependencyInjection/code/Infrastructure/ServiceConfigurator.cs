using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Foundation.DependencyInjection.Extensions;

namespace Foundation.DependencyInjection.Infrastructure
{
    public class ServiceConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMvcControllers("Feature.*");
            serviceCollection.AddClassesWithServiceAttribute("Feature.*");
            serviceCollection.AddClassesWithServiceAttribute("Foundation.*");
        }
    }
}
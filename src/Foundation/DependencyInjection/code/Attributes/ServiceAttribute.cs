using System;
using Foundation.DependencyInjection.Infrastructure;

namespace Foundation.DependencyInjection.Attributes
{
    public class ServiceAttribute : Attribute
    {
        public ServiceAttribute() { }

        public ServiceAttribute(Type serviceType)
        {
            this.ServiceType = serviceType;
        }

        public Lifetime Lifetime { get; set; } = Lifetime.Singleton;
        public Type ServiceType { get; set; }
    }
}
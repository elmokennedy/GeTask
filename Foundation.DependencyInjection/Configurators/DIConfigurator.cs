using Autofac;
using Feature.MyPosts.Modules;

namespace Foundation.DependencyInjection.Configurators
{
    public class DIConfigurator
    {
        public static void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule<MyPostsDIModule>();
        }
    }
}
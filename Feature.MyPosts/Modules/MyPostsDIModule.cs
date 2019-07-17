using System;
using Autofac;
using System.Reflection;
using Feature.MyPosts.Services;
using Feature.MyPosts.Services.Interfaces;
using Autofac.Integration.Mvc;

namespace Feature.MyPosts.Modules
{
    public class MyPostsDIModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<PostService>().As<IPostService>();
            base.Load(builder);
        }
    }
}
﻿using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Microsoft.Owin;
using Owin;
using SOEDU.Entities.Models;
using SOEDU.Repository.Infrastructure;
using SOEDU.Repository.Repositories;
using SOEDU.Service;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;

[assembly: OwinStartup(typeof(SOEDU.Api.App_Start.Startup))]

namespace SOEDU.Api.App_Start
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigAutofac(app);
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
        }

        private void ConfigAutofac(IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()); //Register WebApi Controllers

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            builder.RegisterType<SOEDUEntity>().AsSelf().InstancePerRequest();

            //Asp.net Identity
            //builder.RegisterType<ApplicationUserStore>().As<IUserStore<ApplicationUser>>().InstancePerRequest();
            //builder.RegisterType<ApplicationUserManager>().AsSelf().InstancePerRequest();
            //builder.RegisterType<ApplicationSignInManager>().AsSelf().InstancePerRequest();
            //builder.Register(c => HttpContext.Current.GetOwinContext().Authentication).InstancePerRequest();
            //builder.Register(c => app.GetDataProtectionProvider()).InstancePerRequest();

            // Repositories
            builder.RegisterAssemblyTypes(typeof(CourseRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();

            // Services
            builder.RegisterAssemblyTypes(typeof(CourseService).Assembly)
               .Where(t => t.Name.EndsWith("Service"))
               .AsImplementedInterfaces().InstancePerRequest();

            Autofac.IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container); //Set the WebApi DependencyResolver
        }
    }
}
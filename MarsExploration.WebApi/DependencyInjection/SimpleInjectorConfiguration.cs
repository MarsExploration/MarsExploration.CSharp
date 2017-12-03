using MarsExploration.Domain.CQS;
using MarsExploration.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;
using SimpleInjector.Integration.AspNetCore.Mvc;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsExploration.WebApi.DependencyInjection
{
    public class SimpleInjectorConfiguration
    {
        private static void RegisterDependencies(Container container)
        {
            container.Register(typeof(ICommandHandler<,>), 
                               new[] { typeof(ICommandHandler<,>).Assembly }, 
                               container.Options.DefaultScopedLifestyle);

            container.Register<IProbeMover, ProbeMover>(container.Options.DefaultScopedLifestyle);
            container.Register<IDirectionTurner, DirectionTurner>(container.Options.DefaultScopedLifestyle);
        }

        public static void IntegrateSimpleInjector(IServiceCollection services, Container container)
        {
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            RegisterDependencies(container);

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddSingleton<IControllerActivator>(
                new SimpleInjectorControllerActivator(container));
            services.AddSingleton<IViewComponentActivator>(
                new SimpleInjectorViewComponentActivator(container));

            services.EnableSimpleInjectorCrossWiring(container);
            services.UseSimpleInjectorAspNetRequestScoping(container);
        }
    }
}

using Micromplex.Domain.Core.Bus;
using Micromplex.Infrastructure.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Micromplex.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Bind interfaces with their concrete types

            // Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}

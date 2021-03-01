using MediatR;
using Micromplex.Banking.Application.Interfaces;
using Micromplex.Banking.Application.Services;
using Micromplex.Banking.Data.Context;
using Micromplex.Banking.Data.Repository;
using Micromplex.Banking.Domain.CommandHandlers;
using Micromplex.Banking.Domain.Commands;
using Micromplex.Banking.Domain.Interfaces;
using Micromplex.Domain.Core.Bus;
using Micromplex.Infrastructure.Bus;
using Micromplex.Transfer.Application.Interfaces;
using Micromplex.Transfer.Application.Services;
using Micromplex.Transfer.Data.Context;
using Micromplex.Transfer.Data.Repository;
using Micromplex.Transfer.Domain.EventHandlers;
using Micromplex.Transfer.Domain.Events;
using Micromplex.Transfer.Domain.Interfaces;
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
            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

            // Subscriptions
            services.AddTransient<TransferEventHandler>();

            // Transfer Events
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();

            // Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            // Application Layer (Services)
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();

            // Data Layer


            // ================================
            // Repos
            // ================================
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            

            // ================================
            // Contexts
            // ================================
            services.AddTransient<BankingDbContext>();
            services.AddTransient<TransferDbContext>();
        }
    }
}

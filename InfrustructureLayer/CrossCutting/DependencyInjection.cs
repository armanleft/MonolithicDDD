using Application;
using Application.Contracts;
using Domain;
using Domain.Contract;
using Domain.Contract.Models;
using FacadeGateway;
using Microsoft.Extensions.DependencyInjection;
using Persistence.DbContexts;
using Persistence.Repositories;
using Presentation.Contract.FacadeGatewayInterfaces;
using StructureMap;
using System;

namespace CrossCutting
{
    public static class DependencyInjection
    {
        public static IServiceProvider ConfigureIocContainer(this IServiceCollection services)
        {
            var container = new Container();

            services.AddScoped<ICardFacadeGatewayService, CardFacadeGatewayService>();
            services.AddScoped<ICardCommandHandler, CardCommandHandler>();
            services.AddScoped<IDomainFactory, DomainFactory>();
            services.AddScoped(typeof(IBaseRepository<>), typeof(MongoRepository<>));
            services.AddScoped<IMongoDbContext, MongoDbContext>();

            container.Populate(services);
            return container.GetInstance<IServiceProvider>();
        }
    }
}
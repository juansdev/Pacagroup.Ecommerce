﻿using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Pacagroup.Ecommerce.Application.Interface.UseCases;
using Pacagroup.Ecommerce.Application.UseCases.Categories;
using Pacagroup.Ecommerce.Application.UseCases.Common.Behaviours;
using Pacagroup.Ecommerce.Application.UseCases.Customers;
using Pacagroup.Ecommerce.Application.UseCases.Discounts;
using Pacagroup.Ecommerce.Application.UseCases.Users;
using System.Reflection;

namespace Pacagroup.Ecommerce.Application.UseCases
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
                cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(LoggingBehaviour<,>));
                cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
                cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>));
            });
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<ICustomersApplication, CustomersApplication>();
            services.AddScoped<IUsersApplication, UsersApplication>();
            services.AddScoped<ICategoriesApplication, CategoriesApplication>();
            services.AddScoped<IDiscountsApplication, DiscountsApplication>();

            return services;
        } 
    }
}

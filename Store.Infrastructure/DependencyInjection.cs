﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Store.Domain.Interfaces;
using Store.Infrastructure.Data;
using Store.Infrastructure.Repositories;
using Store.Infrastructure.Services;

namespace Store.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAccountingSoftwareRepository, AccountingSoftwareRepository>();

            //services.AddHttpClient<IAccountingSoftwareHttpClientService, AccountingSoftwareHttpClientService>(options =>
            services.AddHttpClient<AccountingSoftwareHttpClientService>(options =>
            {
                options.BaseAddress = new Uri("https://api.coindesk.com/v1/");
            });

            return services;
        }
    }
}

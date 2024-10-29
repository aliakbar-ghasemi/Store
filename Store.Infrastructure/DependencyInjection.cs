using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Store.Domain.Interfaces;
using Store.Infrastructure.Data;
using Store.Infrastructure.Repositories;

namespace Store.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer("Server=.;Database=StoreDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true;");
            });

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}

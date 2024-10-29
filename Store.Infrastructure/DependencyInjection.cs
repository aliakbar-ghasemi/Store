using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Store.Infrastructure.Data;

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
            return services;
        }
    }
}

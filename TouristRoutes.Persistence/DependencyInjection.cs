using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TouristRoutes.Persistence.Data;
using TouristRoutes.Persistence.Repository;

namespace TouristRoutes.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(
            this IServiceCollection services)
        {
            services.AddSingleton<IUnitOfWork, EfUnitOfWork>();
            return services;
        }
        public static IServiceCollection AddPersistence(this IServiceCollection services,  DbContextOptions options)
        {
            services.AddPersistence() .AddSingleton(
                new AppDbContext((DbContextOptions<AppDbContext>)options));
            return services;
        }
    }
}

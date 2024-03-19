using TouristRoutes.UI.Pages;
using TouristRoutes.UI.ViewModels;

namespace TouristRoutes.UI
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterPages(
            this IServiceCollection services)
        {
            services.AddTransient<TouristRoutesPage>()
                .AddTransient<AttractiveneDetailsPage>()
                .AddTransient<CreateAttractivenePage>()
                .AddTransient<CreateTouristRoutPage>()
                .AddTransient<UpdateTouristPage>()
                .AddTransient<UpdateAttractivenePage>();
            return services;
        }

        public static IServiceCollection RegisterViewModels(
        this IServiceCollection services)
        {
            services.AddTransient<TouristRoutesViewModels>()
                .AddTransient<AttractiveneDetailsViewModel>()
                .AddTransient<CreateAttractivineViewModel>()
                .AddTransient<CreateTouristRoutViewModel>()
                .AddTransient<UpdateTouristRoutVewModel>()
                .AddTransient<UpdateAttractiveneVewModel>();
            return services;
        }
        

    }
}

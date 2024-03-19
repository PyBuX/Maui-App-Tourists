using TouristRoutes.UI.Pages;

namespace TouristRoutes.UI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AttractiveneDetailsPage), typeof(AttractiveneDetailsPage));
            Routing.RegisterRoute(nameof(UpdateAttractivenePage), typeof(UpdateAttractivenePage));
            Routing.RegisterRoute(nameof(CreateAttractivenePage), typeof(CreateAttractivenePage));
            Routing.RegisterRoute(nameof(CreateTouristRoutPage), typeof(CreateTouristRoutPage));
            Routing.RegisterRoute(nameof(UpdateTouristPage), typeof(UpdateTouristPage));
        }
    }
}

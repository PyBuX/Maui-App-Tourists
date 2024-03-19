using TouristRoutes.UI.ViewModels;

namespace TouristRoutes.UI.Pages;

public partial class CreateTouristRoutPage : ContentPage
{
	public CreateTouristRoutPage(IMediator mediator)
	{
		InitializeComponent();
        BindingContext = new CreateTouristRoutViewModel(mediator);
    }
}
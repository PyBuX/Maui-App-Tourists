using TouristRoutes.UI.ViewModels;

namespace TouristRoutes.UI.Pages;

public partial class UpdateTouristPage : ContentPage
{
	public UpdateTouristPage(IMediator mediator)
	{
		InitializeComponent();
        BindingContext = new UpdateTouristRoutVewModel(mediator);
    }
}
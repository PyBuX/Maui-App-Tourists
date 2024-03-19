using TouristRoutes.UI.ViewModels;

namespace TouristRoutes.UI.Pages;

public partial class AttractiveneDetailsPage : ContentPage
{
	public AttractiveneDetailsPage(IMediator mediator)
	{
		InitializeComponent();
		BindingContext = new AttractiveneDetailsViewModel(mediator);

    }
}
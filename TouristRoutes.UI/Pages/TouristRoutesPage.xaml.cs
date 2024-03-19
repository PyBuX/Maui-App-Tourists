namespace TouristRoutes.UI.Pages;
using TouristRoutes.UI.ViewModels;

public partial class TouristRoutesPage : ContentPage
{
	public TouristRoutesPage(IMediator mediator)
	{
		InitializeComponent();
		BindingContext = new TouristRoutesViewModels(mediator);
	}
}
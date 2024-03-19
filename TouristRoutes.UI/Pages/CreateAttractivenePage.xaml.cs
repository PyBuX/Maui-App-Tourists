using TouristRoutes.UI.ViewModels;

namespace TouristRoutes.UI.Pages;

public partial class CreateAttractivenePage : ContentPage
{
	public CreateAttractivenePage(IMediator mediator)
	{
		InitializeComponent();
		BindingContext = new CreateAttractivineViewModel(mediator);
	}
}
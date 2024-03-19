using TouristRoutes.UI.ViewModels;

namespace TouristRoutes.UI.Pages;

public partial class UpdateAttractivenePage : ContentPage
{
	public UpdateAttractivenePage(IMediator mediator)
	{
		InitializeComponent();
		BindingContext = new UpdateAttractiveneVewModel(mediator);	

    }
}
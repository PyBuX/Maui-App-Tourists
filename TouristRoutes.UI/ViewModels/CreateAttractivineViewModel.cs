using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TouristRoutes.Application.AttractiveneUseCases.Commands;
using TouristRoutes.UI.Pages;

namespace TouristRoutes.UI.ViewModels
{

    [QueryProperty("TouristRout", "TouristRout")]
    public partial class CreateAttractivineViewModel : ObservableObject
    {
        private readonly IMediator _mediator;

        [ObservableProperty]
        TouristRout touristRout;

        [ObservableProperty]
        Attractivene attractivene;

        public CreateAttractivineViewModel(IMediator mediator)
        {
            _mediator = mediator;
            attractivene = new Attractivene("","", "", 0);
            
        }

        [RelayCommand]
        async Task Create() => await GoToCreate();

        public async Task GoToCreate()
        {
            attractivene.AddTouristRout(TouristRout);
            var result = await _mediator.Send(new CreateAttractiveneRequest(Attractivene));
            await Shell.Current.GoToAsync($"//{nameof(TouristRoutesPage)}");
        }
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TouristRoutes.Application.AttractiveneUseCases.Commands;
using TouristRoutes.UI.Pages;

namespace TouristRoutes.UI.ViewModels
{
    [QueryProperty("Attractivene", "Attractivene")]
    public partial class UpdateAttractiveneVewModel : ObservableObject
    {
        private readonly IMediator _mediator;

        [ObservableProperty]
        Attractivene attractivene;

        public UpdateAttractiveneVewModel(IMediator mediator) => _mediator = mediator;

        [RelayCommand]
        async Task Update() => await GoToUpdate();

        public async Task GoToUpdate()
        {
            var result = await _mediator.Send(new UpdateAttractiveneRequest(Attractivene));
            await Shell.Current.GoToAsync($"//{nameof(TouristRoutesPage)}");
        }
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TouristRoutes.Application.AttractiveneUseCases.Commands;
using TouristRoutes.Application.TouristRoutUseCases.Commands;
using TouristRoutes.UI.Pages;

namespace TouristRoutes.UI.ViewModels
{
    [QueryProperty("TouristRout", "TouristRout")]
    public partial class UpdateTouristRoutVewModel : ObservableObject
    {
        private readonly IMediator _mediator;

        [ObservableProperty]
        TouristRout touristRout;

        public UpdateTouristRoutVewModel(IMediator mediator) => _mediator = mediator;


        [RelayCommand]
        async Task Update() => await GoToUpdate();

        public async Task GoToUpdate()
        {
            var result = await _mediator.Send(new UpdateTouristRoutCommand(TouristRout));
            await Shell.Current.GoToAsync($"//{nameof(TouristRoutesPage)}");
        }
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TouristRoutes.Application.TouristRoutUseCases.Commands;
using TouristRoutes.UI.Pages;

namespace TouristRoutes.UI.ViewModels
{
    public partial class CreateTouristRoutViewModel : ObservableObject
    {
        private readonly IMediator _mediator;

        [ObservableProperty]
        TouristRout touristRout;

        public CreateTouristRoutViewModel(IMediator mediator)
        {
            _mediator = mediator;
            TouristRout = new TouristRout("", DateTime.Now);
        }

        [RelayCommand]
        async Task Create() => await GoToCreate();

        public async Task GoToCreate()
        {
            var result = await _mediator.Send(new CreateTouristRousRequest(TouristRout));
            await Shell.Current.GoToAsync($"//{nameof(TouristRoutesPage)}");
        }
    }
}
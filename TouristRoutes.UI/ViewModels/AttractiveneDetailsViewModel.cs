using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TouristRoutes.Application.AttractiveneUseCases.Commands;
using TouristRoutes.UI.Pages;

namespace TouristRoutes.UI.ViewModels
{
    [QueryProperty("Attractivene", "Attractivene")]
    public partial class AttractiveneDetailsViewModel : ObservableObject
    {
        private readonly IMediator _mediator;

        [ObservableProperty]
        Attractivene attractivene;

        [ObservableProperty]
        string result;

        public AttractiveneDetailsViewModel(IMediator mediator)
        {
            _mediator = mediator;
        }

        [RelayCommand]
        async Task Remove() => await GoToRemove();

        public async Task GoToRemove()
        {
            var result = await _mediator.Send(new RemoveAttractiveneRequest(Attractivene));
            await Shell.Current.GoToAsync($"//{nameof(TouristRoutesPage)}");
        }

        [RelayCommand]
        async Task Update() => await GoToUpdate();

        public async Task GoToUpdate()
        {
            IDictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "Attractivene", attractivene }
            };

            await Shell.Current.GoToAsync(nameof(UpdateAttractivenePage), parameters);
        }
    }
}

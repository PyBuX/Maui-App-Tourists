using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using TouristRoutes.Application.AttractiveneUseCases.Queries;
using TouristRoutes.Domain.Entities;
using TouristRoutes.UI.Pages;

namespace TouristRoutes.UI.ViewModels
{
    public partial class TouristRoutesViewModels : ObservableObject
    {
        private readonly IMediator _mediator;

        public ObservableCollection<TouristRout> TouristRoutes { get; set; } = new();
        public ObservableCollection<Attractivene> Attractiveness { get; set; } = new();

        public TouristRoutesViewModels(IMediator mediator) => _mediator = mediator;

        [ObservableProperty]
        TouristRout selectedTouristRout;

        [RelayCommand]
        async Task UpdateGroupList() => await GetTouristRoutes();

        private async Task GetTouristRoutes()
        {
            var touristRoutes = await _mediator.Send(new GetTouristRoutesRequest());
            await MainThread.InvokeOnMainThreadAsync(() =>
            {
                TouristRoutes.Clear();
                foreach (var touristRout in touristRoutes)
                    TouristRoutes.Add(touristRout);
            });
        }

        [RelayCommand]
        async Task UpdateMembersList() => await GetAttractiveness();

        private async Task GetAttractiveness()
        {
            if(selectedTouristRout == null) return;
            var attractivess = await _mediator.Send(new GetAttractiveneByTourustRouteIdRequest(SelectedTouristRout.Id));
            
            if(attractivess == null)
            {
                Attractiveness.Clear();
                return;
            }
            
            await MainThread.InvokeOnMainThreadAsync(() =>
            {
                Attractiveness.Clear();
                foreach (var attractive in attractivess)
                    Attractiveness.Add(attractive);
            });
        }

        [RelayCommand]
        async void ShowDetails(Attractivene attractivene) => await GotoDetailsPage(attractivene);

        private async Task GotoDetailsPage(Attractivene attractivene)
        {
            IDictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "Attractivene", attractivene }
            };

            await Shell.Current.GoToAsync(nameof(AttractiveneDetailsPage), parameters);
        }

        [RelayCommand]
        async void ShowCreateAttractivine() => await GotoCreateAttractivine();

        private async Task GotoCreateAttractivine()
        {
            if (selectedTouristRout == null) return;
            IDictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "TouristRout", selectedTouristRout }
            };

            await Shell.Current.GoToAsync(nameof(CreateAttractivenePage), parameters);
        }

        [RelayCommand]
        async void ShowCreateTouristRout() => await GotoCreateTouristRout();

        private async Task GotoCreateTouristRout() => await Shell.Current.GoToAsync(nameof(CreateTouristRoutPage));

        [RelayCommand]
        async Task Update() => await GoToUpdate();

        public async Task GoToUpdate()
        {
            IDictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "TouristRout", selectedTouristRout }
            };

            await Shell.Current.GoToAsync(nameof(UpdateTouristPage), parameters);
        }
    }
}

namespace TouristRoutes.Application.TouristRoutUseCases.Commands
{
    public sealed record CreateTouristRousRequest(TouristRout touristRout) : IRequest<bool> { }
}

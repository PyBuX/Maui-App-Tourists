namespace TouristRoutes.Application.TouristRoutUseCases.Commands
{
    public sealed record UpdateTouristRoutCommand(TouristRout TouristRout) : IRequest<bool>
    {
    }
}

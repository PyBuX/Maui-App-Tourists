namespace TouristRoutes.Application.AttractiveneUseCases.Commands
{

    public sealed record UpdateAttractiveneRequest(Attractivene attractivene) : IRequest<bool> { }
}

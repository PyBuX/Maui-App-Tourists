namespace TouristRoutes.Application.AttractiveneUseCases.Commands
{
    public sealed record CreateAttractiveneRequest(Attractivene attractivene) : IRequest<bool> { }
}

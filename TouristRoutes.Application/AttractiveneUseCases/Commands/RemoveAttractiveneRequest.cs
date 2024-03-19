namespace TouristRoutes.Application.AttractiveneUseCases.Commands
{

    public sealed record RemoveAttractiveneRequest(Attractivene attractivene) : IRequest<bool> { }
}

namespace TouristRoutes.Application.AttractiveneUseCases.Queries
{
    public sealed record GetAttractiveneByTourustRouteIdRequest(Guid Id) : IRequest<IEnumerable<Attractivene>> { }
}

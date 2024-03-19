namespace TouristRoutes.Application.AttractiveneUseCases.Queries
{
    public sealed record GetTouristRoutesRequest() : IRequest<IEnumerable<TouristRout>> { }
}

using TouristRoutes.Application.AttractiveneUseCases.Queries;

namespace TouristRoutes.Application.PatientUseCases.Queries
{
    public class GetAttractiveneByTourustRouteIdRequestHandler(IUnitOfWork unitOfWork) :
    IRequestHandler<GetAttractiveneByTourustRouteIdRequest, IEnumerable<Attractivene>>
    {

        public async Task<IEnumerable<Attractivene>> Handle(
        GetAttractiveneByTourustRouteIdRequest request,
        CancellationToken cancellationToken)
        {
            return await unitOfWork.AttractivenessRepository
            .ListAsync(t => t.TouristRoutId == request.Id,
            cancellationToken);
        }
    }

}

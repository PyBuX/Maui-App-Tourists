using TouristRoutes.Application.AttractiveneUseCases.Queries;

namespace TouristRoutes.Application.PatientUseCases.Queries
{
    public class GetTouristRoutesRequestHandler(IUnitOfWork unitOfWork) :
    IRequestHandler<GetTouristRoutesRequest, IEnumerable<TouristRout>>
    {

        public async Task<IEnumerable<TouristRout>> Handle(
        GetTouristRoutesRequest request,
        CancellationToken cancellationToken)
        {
            return await unitOfWork.TouristRoutesRepository
            .ListAllAsync();
        }
    }

}

namespace TouristRoutes.Application.AttractiveneUseCases.Commands
{

    public class RemoveAttractiveneRequestHandler(IUnitOfWork unitOfWork) :
    IRequestHandler<RemoveAttractiveneRequest, bool>
    {
        public async Task<bool> Handle(RemoveAttractiveneRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.AttractivenessRepository
                .DeleteAsync(request.attractivene);
                return true;
        }
    }
}

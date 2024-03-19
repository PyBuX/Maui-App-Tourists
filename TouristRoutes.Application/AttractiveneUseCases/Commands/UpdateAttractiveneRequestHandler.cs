namespace TouristRoutes.Application.AttractiveneUseCases.Commands
{

    public class UpdateAttractiveneRequestHandler(IUnitOfWork unitOfWork) :
    IRequestHandler<UpdateAttractiveneRequest, bool>
    {
        public async Task<bool> Handle(UpdateAttractiveneRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.AttractivenessRepository
                .UpdateAsync(request.attractivene);
            return true;
        }
    }
}

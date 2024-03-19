namespace TouristRoutes.Application.AttractiveneUseCases.Commands
{
    public class CreateAttractiveneRequestHandler(IUnitOfWork unitOfWork) :
    IRequestHandler<CreateAttractiveneRequest, bool>
    {
        public async Task<bool> Handle(CreateAttractiveneRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.AttractivenessRepository
                .AddAsync(request.attractivene);
            return true;
        }
    }
}

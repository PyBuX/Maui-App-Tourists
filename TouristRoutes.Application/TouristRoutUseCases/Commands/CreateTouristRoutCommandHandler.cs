namespace TouristRoutes.Application.TouristRoutUseCases.Commands
{
    public class CreateTouristRoutCommandHandler(IUnitOfWork unitOfWork) :
    IRequestHandler<CreateTouristRousRequest, bool>
    {
        public async Task<bool> Handle(CreateTouristRousRequest request,
            CancellationToken cancellationToken)
        {
            await unitOfWork.TouristRoutesRepository
                .AddAsync(request.touristRout);
            return true;
        }
    }
}

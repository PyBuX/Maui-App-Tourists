using TouristRoutes.Application.AttractiveneUseCases.Commands;

namespace TouristRoutes.Application.TouristRoutUseCases.Commands
{
    internal class UpdateTouristRoutCommandHandler(IUnitOfWork unitOfWork) :
    IRequestHandler<UpdateTouristRoutCommand, bool>
    {
        public async Task<bool> Handle(UpdateTouristRoutCommand request, CancellationToken cancellationToken)
        {
            await unitOfWork.TouristRoutesRepository
                .UpdateAsync(request.TouristRout);
            return true;
        }
    }
}

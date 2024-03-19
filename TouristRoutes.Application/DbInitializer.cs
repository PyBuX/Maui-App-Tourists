using Microsoft.Extensions.DependencyInjection;

namespace TouristRoutes.Application
{
    public static class DbInitializer
    {

        public static async Task Initialize(IServiceProvider services)
        {
            var unitOfWork = services.GetRequiredService<IUnitOfWork>();
            
            await unitOfWork.DeleteDataBaseAsync();
            await unitOfWork.CreateDataBaseAsync();


            for (int i = 1; i <= 3; i++)
            {
                var touristRout = new TouristRout($"TouristRout {i}", DateTime.Now.AddDays(-Random.Shared.Next(30)));
                unitOfWork.TouristRoutesRepository.AddAsync(touristRout);
                await unitOfWork.SaveAllAsync();
            }

           var TouristRoutes = unitOfWork.TouristRoutesRepository.ListAllAsync();

            for (int i = 1; i <= 15; i++)
            {
                var attractivene = new Attractivene($"Attractivene {i}", $"Location {i}", $"Description {i}", Random.Shared.Next(3000,5000));

                if (TouristRoutes.Result.Count > 0)
                    attractivene.AddTouristRout(TouristRoutes.Result[Random.Shared.Next(0, TouristRoutes.Result.Count)]);

                unitOfWork.AttractivenessRepository.AddAsync(attractivene);
                await unitOfWork.SaveAllAsync();
            }

            await unitOfWork.SaveAllAsync();
        }
    }
}

using TouristRoutes.Domain.Entities;

namespace TouristRoutes.Domain.Abstractions
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// Репозиторий туристических маршрутов
        /// </summary>
        IRepository<TouristRout> TouristRoutesRepository { get; }

        /// <summary>
        /// Репозиторий достопримечательностей
        /// </summary>
        IRepository<Attractivene> AttractivenessRepository { get; }

        /// <summary>
        /// Сохранение данных
        /// </summary>
        /// <returns></returns>
        Task SaveAllAsync();

        /// <summary>
        /// Удаление базы данных
        /// </summary>
        /// <returns></returns>
        Task DeleteDataBaseAsync();

        /// <summary>
        /// Создание базы данных
        /// </summary>
        /// <returns></returns>
        Task CreateDataBaseAsync();
    }
}

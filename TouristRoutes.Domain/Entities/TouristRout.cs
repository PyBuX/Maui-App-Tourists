namespace TouristRoutes.Domain.Entities
{
    /// <summary>
    /// Туристический маршрут
    /// </summary>
    public class TouristRout : Entity
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Коллекция достопримечательностей
        /// </summary>
        public List<Attractivene> Attractiveness { get; set; } = new();

        private TouristRout() {}

        public TouristRout(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }
    }
}

namespace TouristRoutes.Domain.Entities
{
    /// <summary>
    /// Достопримечательность
    /// </summary>
    public class Attractivene : Entity
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Локация
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Стоимость билета
        /// </summary>
        public decimal TicketPrice { get; set; }

        /// <summary>
        /// Индификатор маршрута
        /// </summary>
        public Guid? TouristRoutId { get; set; }

        /// <summary>
        /// Маршрут
        /// </summary>
        public TouristRout? TouristRout { get; set; }

        private Attractivene() { }

        public Attractivene(string name, string location, string description, decimal ticketPrice)
        {
            Name = name;
            Location = location;
            Description = description;
            TicketPrice = ticketPrice;
        }

        public void AddTouristRout(TouristRout touristRout)
        {
            TouristRout = touristRout;
            TouristRoutId = touristRout.Id;
        }
    }
}

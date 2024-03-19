using TouristRoutes.Persistence.Data;

namespace TouristRoutes.Persistence.Repository
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly Lazy<IRepository<TouristRout>> _touristRoutesRepository;
        private readonly Lazy<IRepository<Attractivene>> _attractivenessRepository;

        public EfUnitOfWork(AppDbContext context)
        {
            _context = context;
            _attractivenessRepository = new Lazy<IRepository<Attractivene>>(() =>  new EfRepository<Attractivene>(context));
            _touristRoutesRepository = new Lazy<IRepository<TouristRout>>(() => new EfRepository<TouristRout>(context));
        }

        public IRepository<TouristRout> TouristRoutesRepository => _touristRoutesRepository.Value;

        public IRepository<Attractivene> AttractivenessRepository => _attractivenessRepository.Value;

        public async Task CreateDataBaseAsync() => await _context.Database.EnsureCreatedAsync();
        public async Task DeleteDataBaseAsync() =>  await _context.Database.EnsureDeletedAsync();
        public async Task SaveAllAsync() =>  await _context.SaveChangesAsync();
    }
}

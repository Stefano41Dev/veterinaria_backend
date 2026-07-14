using veterinaria_backend.Domain.Interfaces;
using veterinaria_backend.Domain.Models;

namespace veterinaria_backend.Infrastructure.Repository
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly DbVeterinarySjlContext _context;
        public OwnerRepository(DbVeterinarySjlContext context) { 
            _context = context;
        }
        public List<Owner> FindAll()
        {
            

            return null;
        }

        public Owner? FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Owner? FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public Owner Save(Owner owner)
        {
            throw new NotImplementedException();
        }
    }
}

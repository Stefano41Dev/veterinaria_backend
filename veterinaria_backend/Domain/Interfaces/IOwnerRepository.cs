using veterinaria_backend.Domain.Models;

namespace veterinaria_backend.Domain.Interfaces
{
    public interface IOwnerRepository
    {
        Owner Save(Owner owner);
        Owner? FindById(Guid id);
        Owner? FindByName(string name);
        
        List<Owner> FindAll();
    }
}

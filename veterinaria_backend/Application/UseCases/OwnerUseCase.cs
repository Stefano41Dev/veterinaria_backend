using veterinaria_backend.Application.Dtos;
using veterinaria_backend.Domain.Models;

namespace veterinaria_backend.Application.UseCases
{
    public interface OwnerUseCase
    {
        Owner Save(OwnerDtoRequest request);
        Owner Update(Guid id,OwnerDtoRequest request);
        Owner? FindById(Guid id);
        void Delete(Guid id);
        Owner FindByName(string name);

    }
}

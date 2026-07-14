using veterinaria_backend.Application.Dtos;
using veterinaria_backend.Application.UseCases;
using veterinaria_backend.Domain.Models;

namespace veterinaria_backend.Application.Services
{
    public class OwnerService : OwnerUseCase
    {
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Owner? FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Owner FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public Owner Update(Guid id, OwnerDtoRequest request)
        {
            throw new NotImplementedException();
        }

        Owner OwnerUseCase.Save(OwnerDtoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

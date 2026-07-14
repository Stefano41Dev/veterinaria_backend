using veterinaria_backend.Application.Dtos;
using veterinaria_backend.Domain.Models;

namespace veterinaria_backend.Application.UseCases
{
    public interface OwnerUseCase
    {
        Owner Save(OwnerDtoRequest request);

    }
}

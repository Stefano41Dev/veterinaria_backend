namespace veterinaria_backend.Application.Dtos
{
    public record OwnerDtoRequest(
        string FirstName,
        string LastName,
        string Dni,
        string Phone,
        string Email,
        string Address
        )
    {}
}

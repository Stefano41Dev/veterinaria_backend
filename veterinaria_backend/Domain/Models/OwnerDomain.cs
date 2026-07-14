namespace veterinaria_backend.Domain.Models;

public class OwnerDomain
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Dni { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public DateTime? CreatedAt { get; set; }

    public ICollection<PetDomain> Pets { get; set; } = new List<PetDomain>();
}

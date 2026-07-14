namespace veterinaria_backend.Domain.Models;

public class RoleDomain
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public ICollection<UserDomain> Users { get; set; } = new List<UserDomain>();
}

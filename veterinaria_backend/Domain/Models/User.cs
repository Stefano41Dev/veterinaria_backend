namespace veterinaria_backend.Domain.Models;

public class User
{
    public Guid Id { get; set; }

    public int RoleId { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? Phone { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public Role Role { get; set; } = null!;

    public ICollection<Veterinarian> Veterinarians { get; set; } = new List<Veterinarian>();
}

namespace veterinaria_backend.Domain.Models;

public class Species
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public ICollection<Breed> Breeds { get; set; } = new List<Breed>();
}

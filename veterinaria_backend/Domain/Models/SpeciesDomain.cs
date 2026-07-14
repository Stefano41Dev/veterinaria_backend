namespace veterinaria_backend.Domain.Models;

public class SpeciesDomain
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public ICollection<BreedDomain> Breeds { get; set; } = new List<BreedDomain>();
}

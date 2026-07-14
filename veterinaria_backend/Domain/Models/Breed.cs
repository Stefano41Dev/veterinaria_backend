namespace veterinaria_backend.Domain.Models;

public class Breed
{
    public int Id { get; set; }

    public int SpeciesId { get; set; }

    public string Name { get; set; } = null!;

    public ICollection<Pet> Pets { get; set; } = new List<Pet>();

    public Species Species { get; set; } = null!;
}

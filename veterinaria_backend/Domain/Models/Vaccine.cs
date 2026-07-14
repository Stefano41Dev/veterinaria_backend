namespace veterinaria_backend.Domain.Models;

public class Vaccine
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Manufacturer { get; set; }

    public string? Description { get; set; }

    public ICollection<Vaccination> Vaccinations { get; set; } = new List<Vaccination>();
}

namespace veterinaria_backend.Domain.Models;

public class VaccineDomain
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Manufacturer { get; set; }

    public string? Description { get; set; }

    public ICollection<VaccinationDomain> Vaccinations { get; set; } = new List<VaccinationDomain>();
}

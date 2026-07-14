namespace veterinaria_backend.Domain.Models;

public class PetDomain
{
    public Guid Id { get; set; }

    public Guid OwnerId { get; set; }

    public int BreedId { get; set; }

    public string Name { get; set; } = null!;

    public string Sex { get; set; } = null!;

    public DateOnly? BirthDate { get; set; }

    public decimal? Weight { get; set; }

    public string? Color { get; set; }

    public bool Sterilized { get; set; }

    public string? Notes { get; set; }

    public bool? IsActive { get; set; }

    public ICollection<AppointmentDomain> Appointments { get; set; } = new List<AppointmentDomain>();

    public BreedDomain Breed { get; set; } = null!;

    public OwnerDomain Owner { get; set; } = null!;

    public ICollection<VaccinationDomain> Vaccinations { get; set; } = new List<VaccinationDomain>();
}

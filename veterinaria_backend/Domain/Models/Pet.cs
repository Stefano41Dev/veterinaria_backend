namespace veterinaria_backend.Domain.Models;

public class Pet
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

    public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public Breed Breed { get; set; } = null!;

    public Owner Owner { get; set; } = null!;

    public ICollection<Vaccination> Vaccinations { get; set; } = new List<Vaccination>();
}

namespace veterinaria_backend.Domain.Models;

public class Veterinarian
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string LicenseNumber { get; set; } = null!;

    public string? Specialty { get; set; }

    public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();

    public User User { get; set; } = null!;

    public ICollection<Vaccination> Vaccinations { get; set; } = new List<Vaccination>();
}

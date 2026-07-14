namespace veterinaria_backend.Domain.Models;

public class VeterinarianDomain
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string LicenseNumber { get; set; } = null!;

    public string? Specialty { get; set; }

    public ICollection<AppointmentDomain> Appointments { get; set; } = new List<AppointmentDomain>();

    public ICollection<PrescriptionDomain> Prescriptions { get; set; } = new List<PrescriptionDomain>();

    public UserDomain User { get; set; } = null!;

    public ICollection<VaccinationDomain> Vaccinations { get; set; } = new List<VaccinationDomain>();
}

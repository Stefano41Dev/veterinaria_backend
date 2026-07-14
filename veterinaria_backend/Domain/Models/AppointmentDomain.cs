namespace veterinaria_backend.Domain.Models;

public class Appointment
{
    public Guid Id { get; set; }

    public Guid PetId { get; set; }

    public Guid VeterinarianId { get; set; }

    public DateTime AppointmentDate { get; set; }

    public string? Reason { get; set; }

    public string Status { get; set; } = null!;

    public string? Notes { get; set; }

    public MedicalRecord? MedicalRecord { get; set; }

    public Pet Pet { get; set; } = null!;

    public Veterinarian Veterinarian { get; set; } = null!;
}

namespace veterinaria_backend.Domain.Models;

public class MedicalRecord
{
    public Guid Id { get; set; }

    public Guid AppointmentId { get; set; }

    public string? Diagnosis { get; set; }

    public string? Symptoms { get; set; }

    public string? Treatment { get; set; }

    public string? Recommendations { get; set; }

    public DateTime ConsultationDate { get; set; }

    public Appointment Appointment { get; set; } = null!;

    public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
}

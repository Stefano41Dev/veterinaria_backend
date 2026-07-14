namespace veterinaria_backend.Domain.Models;

public class Prescription
{
    public Guid Id { get; set; }

    public Guid MedicalRecordId { get; set; }

    public Guid VeterinarianId { get; set; }

    public string? Instructions { get; set; }

    public DateTime? CreatedAt { get; set; }

    public MedicalRecord MedicalRecord { get; set; } = null!;

    public ICollection<PrescriptionItem> PrescriptionItems { get; set; } = new List<PrescriptionItem>();

    public Veterinarian Veterinarian { get; set; } = null!;
}

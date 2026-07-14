namespace veterinaria_backend.Domain.Models;

public class PrescriptionDomain
{
    public Guid Id { get; set; }

    public Guid MedicalRecordId { get; set; }

    public Guid VeterinarianId { get; set; }

    public string? Instructions { get; set; }

    public DateTime? CreatedAt { get; set; }

    public MedicalRecordDomain MedicalRecord { get; set; } = null!;

    public ICollection<PrescriptionItemDomain> PrescriptionItems { get; set; } = new List<PrescriptionItemDomain>();

    public VeterinarianDomain Veterinarian { get; set; } = null!;
}

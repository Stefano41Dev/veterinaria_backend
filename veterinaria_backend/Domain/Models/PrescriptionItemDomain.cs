namespace veterinaria_backend.Domain.Models;

public class PrescriptionItemDomain
{
    public Guid Id { get; set; }

    public Guid PrescriptionId { get; set; }

    public Guid MedicineId { get; set; }

    public string? Dosage { get; set; }

    public string? Frequency { get; set; }

    public string? Duration { get; set; }

    public MedicineDomain Medicine { get; set; } = null!;

    public PrescriptionDomain Prescription { get; set; } = null!;
}

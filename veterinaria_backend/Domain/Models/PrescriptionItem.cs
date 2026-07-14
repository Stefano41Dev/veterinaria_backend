namespace veterinaria_backend.Domain.Models;

public class PrescriptionItem
{
    public Guid Id { get; set; }

    public Guid PrescriptionId { get; set; }

    public Guid MedicineId { get; set; }

    public string? Dosage { get; set; }

    public string? Frequency { get; set; }

    public string? Duration { get; set; }

    public Medicine Medicine { get; set; } = null!;

    public Prescription Prescription { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace veterinaria_backend.Models;

public partial class PrescriptionItem
{
    public Guid Id { get; set; }

    public Guid PrescriptionId { get; set; }

    public Guid MedicineId { get; set; }

    public string? Dosage { get; set; }

    public string? Frequency { get; set; }

    public string? Duration { get; set; }

    public virtual Medicine Medicine { get; set; } = null!;

    public virtual Prescription Prescription { get; set; } = null!;
}

using System;
using System.Collections.Generic;

namespace veterinaria_backend.Models;

public partial class Prescription
{
    public Guid Id { get; set; }

    public Guid MedicalRecordId { get; set; }

    public Guid VeterinarianId { get; set; }

    public string? Instructions { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual MedicalRecord MedicalRecord { get; set; } = null!;

    public virtual ICollection<PrescriptionItem> PrescriptionItems { get; set; } = new List<PrescriptionItem>();

    public virtual Veterinarian Veterinarian { get; set; } = null!;
}

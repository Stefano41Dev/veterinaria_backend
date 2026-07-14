using System;
using System.Collections.Generic;

namespace veterinaria_backend.Infrastructure.Models;

public partial class MedicalRecord
{
    public Guid Id { get; set; }

    public Guid AppointmentId { get; set; }

    public string? Diagnosis { get; set; }

    public string? Symptoms { get; set; }

    public string? Treatment { get; set; }

    public string? Recommendations { get; set; }

    public DateTime ConsultationDate { get; set; }

    public virtual Appointment Appointment { get; set; } = null!;

    public virtual ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
}

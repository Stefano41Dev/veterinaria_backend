using System;
using System.Collections.Generic;

namespace veterinaria_backend.Models;

public partial class Appointment
{
    public Guid Id { get; set; }

    public Guid PetId { get; set; }

    public Guid VeterinarianId { get; set; }

    public DateTime AppointmentDate { get; set; }

    public string? Reason { get; set; }

    public string Status { get; set; } = null!;

    public string? Notes { get; set; }

    public virtual MedicalRecord? MedicalRecord { get; set; }

    public virtual Pet Pet { get; set; } = null!;

    public virtual Veterinarian Veterinarian { get; set; } = null!;
}

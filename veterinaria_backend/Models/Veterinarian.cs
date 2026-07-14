using System;
using System.Collections.Generic;

namespace veterinaria_backend.Models;

public partial class Veterinarian
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string LicenseNumber { get; set; } = null!;

    public string? Specialty { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();

    public virtual User User { get; set; } = null!;

    public virtual ICollection<Vaccination> Vaccinations { get; set; } = new List<Vaccination>();
}

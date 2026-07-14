using System;
using System.Collections.Generic;

namespace veterinaria_backend.Models;

public partial class Vaccination
{
    public Guid Id { get; set; }

    public Guid PetId { get; set; }

    public int VaccineId { get; set; }

    public Guid VeterinarianId { get; set; }

    public DateOnly ApplicationDate { get; set; }

    public DateOnly? NextDoseDate { get; set; }

    public string? LotNumber { get; set; }

    public string? Notes { get; set; }

    public virtual Pet Pet { get; set; } = null!;

    public virtual Vaccine Vaccine { get; set; } = null!;

    public virtual Veterinarian Veterinarian { get; set; } = null!;
}

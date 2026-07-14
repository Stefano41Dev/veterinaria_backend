using System;
using System.Collections.Generic;

namespace veterinaria_backend.Infrastructure.Models;

public partial class Pet
{
    public Guid Id { get; set; }

    public Guid OwnerId { get; set; }

    public int BreedId { get; set; }

    public string Name { get; set; } = null!;

    public string Sex { get; set; } = null!;

    public DateOnly? BirthDate { get; set; }

    public decimal? Weight { get; set; }

    public string? Color { get; set; }

    public bool Sterilized { get; set; }

    public string? Notes { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual Breed Breed { get; set; } = null!;

    public virtual Owner Owner { get; set; } = null!;

    public virtual ICollection<Vaccination> Vaccinations { get; set; } = new List<Vaccination>();
}

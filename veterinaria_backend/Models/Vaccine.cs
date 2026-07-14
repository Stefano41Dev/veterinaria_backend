using System;
using System.Collections.Generic;

namespace veterinaria_backend.Models;

public partial class Vaccine
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Manufacturer { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Vaccination> Vaccinations { get; set; } = new List<Vaccination>();
}

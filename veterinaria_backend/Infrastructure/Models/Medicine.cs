using System;
using System.Collections.Generic;

namespace veterinaria_backend.Infrastructure.Models;

public partial class Medicine
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Concentration { get; set; }

    public int Stock { get; set; }

    public decimal Price { get; set; }

    public virtual ICollection<PrescriptionItem> PrescriptionItems { get; set; } = new List<PrescriptionItem>();
}

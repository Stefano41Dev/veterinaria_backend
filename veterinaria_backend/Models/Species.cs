using System;
using System.Collections.Generic;

namespace veterinaria_backend.Models;

public partial class Species
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Breed> Breeds { get; set; } = new List<Breed>();
}

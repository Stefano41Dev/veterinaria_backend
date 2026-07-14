using System;
using System.Collections.Generic;

namespace veterinaria_backend.Models;

public partial class Breed
{
    public int Id { get; set; }

    public int SpeciesId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Pet> Pets { get; set; } = new List<Pet>();

    public virtual Species Species { get; set; } = null!;
}

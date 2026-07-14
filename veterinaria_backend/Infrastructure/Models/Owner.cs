using System;
using System.Collections.Generic;

namespace veterinaria_backend.Infrastructure.Models;

public partial class Owner
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Dni { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Pet> Pets { get; set; } = new List<Pet>();
}

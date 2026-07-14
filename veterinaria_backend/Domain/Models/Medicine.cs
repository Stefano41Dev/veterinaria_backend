namespace veterinaria_backend.Domain.Models;

public class Medicine
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Concentration { get; set; }

    public int Stock { get; set; }

    public decimal Price { get; set; }

    public ICollection<PrescriptionItem> PrescriptionItems { get; set; } = new List<PrescriptionItem>();
}

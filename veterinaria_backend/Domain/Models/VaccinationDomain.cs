namespace veterinaria_backend.Domain.Models;

public class VaccinationDomain
{
    public Guid Id { get; set; }

    public Guid PetId { get; set; }

    public int VaccineId { get; set; }

    public Guid VeterinarianId { get; set; }

    public DateOnly ApplicationDate { get; set; }

    public DateOnly? NextDoseDate { get; set; }

    public string? LotNumber { get; set; }

    public string? Notes { get; set; }

    public PetDomain Pet { get; set; } = null!;

    public VaccineDomain Vaccine { get; set; } = null!;

    public VeterinarianDomain Veterinarian { get; set; } = null!;
}

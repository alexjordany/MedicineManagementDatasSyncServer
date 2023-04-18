using Microsoft.AspNetCore.Datasync.EFCore;

namespace MedicineManagement.Server.Models;

public class Medicine : EntityTableData
{
    public string MedicineName { get; set; } = string.Empty;
    public int? MedicineQuantity { get; set; }
    public DateTime MedicineExpiration { get; set; }
    public string? MedicineDescription { get; set; }
}


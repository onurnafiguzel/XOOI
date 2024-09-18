namespace XOOI.API.Commands.Maintenance;

public class MaintenanceCreateDto
{
    public int VehicleId { get; set; }
    public int UserId { get; set; }
    public string Description { get; set; }
    public string MaintenanceType { get; set; }
    public string DomainSpecificExceptionsToFix { get; set; }
    public DateTime? ExpectedTimeToFix { get; set; }
    public string LocationLongitude { get; set; }
    public string LocationLatitude { get; set; }
}

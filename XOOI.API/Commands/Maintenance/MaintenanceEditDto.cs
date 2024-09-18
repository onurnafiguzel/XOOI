namespace XOOI.API.Commands.Maintenance;

public class MaintenanceEditDto
{
    public int Id { get; set; }
    public int VehicleId { get; set; }
    public int UserId { get; set; }
    public string Description { get; set; }
    public string MaintenanceType { get; set; }
    public string DomainSpecificExceptionsToFix { get; set; }
    public DateTime? ExpectedTimeToFix { get; set; }
    public string LocationLongitude { get; set; }
    public string LocationLatitude { get; set; }
    public DateTime ModifyDate { get; set; }
    public int ModifiedBy { get; set; }
    public bool IsDeleted { get; set; }
}

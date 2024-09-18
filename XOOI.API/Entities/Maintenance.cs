namespace XOOI.API.Entity;

public class Maintenance
{
	public int ID { get; set; }
	public int VehicleID { get; set; }
	public int UserID { get; set; }
	public int? PictureGroupID { get; set; }
	public string Description { get; set; }
	public DateTime? ExpectedTimeToFix { get; set; }
	public int ResponsibleUserID { get; set; }
	public string LocationLongitude { get; set; }
	public string LocationLatitude { get; set; }
	public int StatusID { get; set; }
	public DateTime CreateDate { get; set; }
	public int CreatedBy { get; set; }
	public DateTime ModifyDate { get; set; }
	public int ModifiedBy { get; set; }
	public bool IsDeleted { get; set; }

	// Navigation properties
	public Vehicle Vehicle { get; set; }
	public User User { get; set; }
	public Status Status { get; set; }
	public PictureGroup PictureGroup { get; set; }
	public ICollection<MaintenanceHistory> MaintenanceHistories { get; set; }
}

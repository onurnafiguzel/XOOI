namespace XOOI.API.Entity;

public class ActionType
{
	public int ID { get; set; }
	public string Name { get; set; }
	public DateTime CreateDate { get; set; }
	public int CreatedBy { get; set; }
	public DateTime ModifyDate { get; set; }
	public int ModifiedBy { get; set; }
	public bool IsDeleted { get; set; }

	// Navigation properties
	public ICollection<MaintenanceHistory> MaintenanceHistories { get; set; }
}

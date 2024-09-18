namespace XOOI.API.Entity;

public class MaintenanceHistory
{
	public int ID { get; set; }
	public int MaintenanceID { get; set; }
	public int ActionTypeID { get; set; }
	public DateTime CreateDate { get; set; }
	public int CreatedBy { get; set; }
	public DateTime ModifyDate { get; set; }
	public int ModifiedBy { get; set; }
	public bool IsDeleted { get; set; }
	public string Text { get; set; }

	// Navigation properties
	public Maintenance Maintenance { get; set; }
	public ActionType ActionType { get; set; }
}

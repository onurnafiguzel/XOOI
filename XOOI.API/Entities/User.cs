namespace XOOI.API.Entities;

public class User
{
	public int ID { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string PhoneNumber { get; set; }
	public string Address { get; set; }
	public DateTime CreateDate { get; set; }
	public int CreatedBy { get; set; }
	public DateTime ModifyDate { get; set; }
	public int ModifiedBy { get; set; }
	public bool IsDeleted { get; set; }
	public string ProfilePicture { get; set; }

	// Navigation properties
	public ICollection<Maintenance> Maintenances { get; set; }
	public ICollection<Vehicle> Vehicles { get; set; }
	public ICollection<MaintenanceHistory> MaintenanceHistories { get; set; }
}

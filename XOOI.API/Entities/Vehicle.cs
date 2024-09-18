namespace XOOI.API.Entity;

public class Vehicle
{
	public int ID { get; set; }
	public string PlateNo { get; set; }
	public int VehicleTypeID { get; set; }
	public int UserID { get; set; }
	public DateTime CreateDate { get; set; }
	public int CreatedBy { get; set; }
	public DateTime ModifyDate { get; set; }
	public int ModifiedBy { get; set; }
	public bool IsDeleted { get; set; }

	// Navigation properties
	public VehicleType VehicleType { get; set; }
	public User User { get; set; }
	public ICollection<Maintenance> Maintenances { get; set; }
}

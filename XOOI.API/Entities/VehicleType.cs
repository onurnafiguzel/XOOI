namespace XOOI.API.Entities;

public class VehicleType
{
	public int ID { get; set; }
	public string Name { get; set; }
	public DateTime CreateDate { get; set; }
	public int CreatedBy { get; set; }
	public DateTime ModifyDate { get; set; }
	public int ModifiedBy { get; set; }
	public bool IsDeleted { get; set; }

	// Navigation properties
	public ICollection<Vehicle> Vehicles { get; set; }
}

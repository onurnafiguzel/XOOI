namespace XOOI.API.Entity;

public class PictureGroup
{
	public int ID { get; set; }
	public string PictureImage { get; set; }
	public DateTime CreateDate { get; set; }
	public int CreatedBy { get; set; }
	public DateTime ModifyDate { get; set; }
	public int ModifiedBy { get; set; }
	public bool IsDeleted { get; set; }

	// Navigation properties
	public ICollection<Maintenance> Maintenances { get; set; }
}

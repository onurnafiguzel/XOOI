namespace XOOI.API.Entities;

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

    private Vehicle() { }

    public static Vehicle Create(string plateNo, int vehicleTypeId, int userId, int createdBy)
    {
        return new Vehicle
        {
            PlateNo = plateNo,
            VehicleTypeID = vehicleTypeId,
            UserID = userId,
            CreatedBy = createdBy,
            CreateDate = DateTime.UtcNow,
            IsDeleted = false
        };
    }

    public void Modify(string plateNo, int vehicleTypeId, int userId, int modifiedBy)
    {
        PlateNo = plateNo;
        VehicleTypeID = vehicleTypeId;
        UserID = userId;
        ModifiedBy = modifiedBy;
        ModifyDate = DateTime.UtcNow;
    }

    public void Delete(int modifiedBy)
    {
        IsDeleted = true;
        ModifiedBy = modifiedBy;
        ModifyDate = DateTime.UtcNow;
    }
}

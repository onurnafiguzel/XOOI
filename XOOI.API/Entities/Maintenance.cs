namespace XOOI.API.Entities;

public class Maintenance
{
    // Immutable primary key
    public int ID { get; init; }

    // Foreign keys - mutable but controlled through methods
    public int VehicleID { get; set; }
    public int UserID { get; set; }
    public int? PictureGroupID { get; set; }
    public int ResponsibleUserID { get; set; }
    public int StatusID { get; set; }

    // Domain-specific properties
    public string Description { get; set; }
    public DateTime? ExpectedTimeToFix { get; set; }
    public string LocationLongitude { get; set; }
    public string LocationLatitude { get; set; }

    // Audit fields (usually these fields are handled by the framework, but can be updated through specific logic)
    public DateTime CreateDate { get; set; }
    public int CreatedBy { get; set; }
    public DateTime ModifyDate { get; set; }
    public int ModifiedBy { get; set; }

    // Soft delete flag
    public bool IsDeleted { get; set; }

    // Navigation properties
    public Vehicle Vehicle { get; set; }
    public User User { get; set; }
    public Status Status { get; set; }
    public PictureGroup PictureGroup { get; set; }

    // One-to-Many Relationship with MaintenanceHistory
    public ICollection<MaintenanceHistory> MaintenanceHistories { get; set; }


    private Maintenance() { }

    // Static Create method to replace the public constructor
    public static Maintenance Create(
        int vehicleId,
        int userId,
        string description,
        DateTime? expectedTimeToFix,
        int statusId,
        int responsibleUserId,
        string locationLongitude,
        string locationLatitude,
        int pictureGroupId,
        int createdBy)
    {
        // Validation or business logic can be applied here before entity creation
        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException("Description cannot be empty.");

        if (string.IsNullOrWhiteSpace(locationLongitude) || string.IsNullOrWhiteSpace(locationLatitude))
            throw new ArgumentException("Location cannot be empty.");

        return new Maintenance
        {
            VehicleID = vehicleId,
            UserID = userId,
            Description = description,
            ExpectedTimeToFix = expectedTimeToFix,
            StatusID = statusId,
            ResponsibleUserID = responsibleUserId,
            LocationLongitude = locationLongitude,
            LocationLatitude = locationLatitude,
            PictureGroupID = pictureGroupId,
            CreatedBy = createdBy,
            CreateDate = DateTime.UtcNow,
            IsDeleted = false // Initially, the entity is not deleted
        };
    }

    public void UpdateStatus(int newStatusId)
    {
        StatusID = newStatusId;
    }

    public void UpdateExpectedTimeToFix(DateTime newTime)
    {
        ExpectedTimeToFix = newTime;
    }

    public void ChangeResponsibleUser(int newResponsibleUserId)
    {
        ResponsibleUserID = newResponsibleUserId;
    }

    public void UpdateLocation(string newLongitude, string newLatitude)
    {
        LocationLongitude = newLongitude;
        LocationLatitude = newLatitude;
    }

    // Method to soft delete this Maintenance entity
    public void Delete(int modifiedBy)
    {
        IsDeleted = true;
        ModifiedBy = modifiedBy;
        ModifyDate = DateTime.UtcNow;
    }

    // Method to modify the entity (audit fields should be updated)
    public void Modify(int modifiedBy, string newDescription, string newLongitude, string newLatitude)
    {
        Description = newDescription;
        LocationLongitude = newLongitude;
        LocationLatitude = newLatitude;
        ModifiedBy = modifiedBy;
        ModifyDate = DateTime.UtcNow;
    }
}

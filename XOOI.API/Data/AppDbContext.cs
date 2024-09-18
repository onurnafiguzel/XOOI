using Microsoft.EntityFrameworkCore;
using XOOI.API.Entity;

namespace XOOI.API.Data;
public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{
	}

	// DbSet properties
	public DbSet<Maintenance> Maintenances { get; set; }
	public DbSet<Vehicle> Vehicles { get; set; }
	public DbSet<User> Users { get; set; }
	public DbSet<Status> Statuses { get; set; }
	public DbSet<PictureGroup> PictureGroups { get; set; }
	public DbSet<MaintenanceHistory> MaintenanceHistories { get; set; }
	public DbSet<ActionType> ActionTypes { get; set; }
	public DbSet<VehicleType> VehicleTypes { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		// Configure entity properties & relationships
		modelBuilder.Entity<Maintenance>()
			.HasOne(m => m.Vehicle)
			.WithMany(v => v.Maintenances)
			.HasForeignKey(m => m.VehicleID);

		modelBuilder.Entity<Maintenance>()
			.HasOne(m => m.User)
			.WithMany(u => u.Maintenances)
			.HasForeignKey(m => m.UserID);

		modelBuilder.Entity<Maintenance>()
			.HasOne(m => m.Status)
			.WithMany(s => s.Maintenances)
			.HasForeignKey(m => m.StatusID);

		modelBuilder.Entity<Maintenance>()
			.HasOne(m => m.PictureGroup)
			.WithMany(pg => pg.Maintenances)
			.HasForeignKey(m => m.PictureGroupID);

		modelBuilder.Entity<MaintenanceHistory>()
			.HasOne(mh => mh.Maintenance)
			.WithMany(m => m.MaintenanceHistories)
			.HasForeignKey(mh => mh.MaintenanceID);

		modelBuilder.Entity<MaintenanceHistory>()
			.HasOne(mh => mh.ActionType)
			.WithMany(at => at.MaintenanceHistories)
			.HasForeignKey(mh => mh.ActionTypeID);

		modelBuilder.Entity<Vehicle>()
			.HasOne(v => v.VehicleType)
			.WithMany(vt => vt.Vehicles)
			.HasForeignKey(v => v.VehicleTypeID);

		modelBuilder.Entity<Vehicle>()
			.HasOne(v => v.User)
			.WithMany(u => u.Vehicles)
			.HasForeignKey(v => v.UserID);

		// Unique or Index configurations
		modelBuilder.Entity<Vehicle>()
			.HasIndex(v => v.PlateNo)
			.IsUnique();

		// Optional: Fluent API for specific field lengths or other constraints
		modelBuilder.Entity<User>()
			.Property(u => u.FirstName)
			.HasMaxLength(255);

		modelBuilder.Entity<User>()
			.Property(u => u.LastName)
			.HasMaxLength(255);

		modelBuilder.Entity<User>()
			.Property(u => u.PhoneNumber)
			.HasMaxLength(50);

		modelBuilder.Entity<Vehicle>()
			.Property(v => v.PlateNo)
			.HasMaxLength(60);
	}
}


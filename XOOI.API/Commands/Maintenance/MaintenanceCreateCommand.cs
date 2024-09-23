using MediatR;
using XOOI.API.Data.UnitOfWork;

namespace XOOI.API.Commands.Maintenance;

public class MaintenanceCreateCommand : IRequest<Task>
{
    public int VehicleId { get; set; }
    public int UserId { get; set; }
    public string Description { get; set; }
    public string MaintenanceType { get; set; }
    public string DomainSpecificExceptionsToFix { get; set; }
	public int StatusId { get; set; }
	public int ResponsibleUserId { get; set; }
	public DateTime? ExpectedTimeToFix { get; set; }
    public string LocationLongitude { get; set; }
    public string LocationLatitude { get; set; }
    public int PictureGroupId { get; set; }
}

public class MaintenanceCreateCommandHandler : IRequestHandler<MaintenanceCreateCommand,Task>
{
	private readonly IUnitOfWork _unitOfWork;

	public MaintenanceCreateCommandHandler(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;
	}

	public async Task<Task> Handle(MaintenanceCreateCommand request, CancellationToken cancellationToken)
	{
		var maintenanceRepository = _unitOfWork.GetRepository<Entities.Maintenance>();
		var maintenance = Entities.Maintenance.Create(request.VehicleId, request.UserId, request.Description, request.ExpectedTimeToFix, request.StatusId, request.ResponsibleUserId, request.LocationLongitude, request.LocationLatitude, request.PictureGroupId);
		await maintenanceRepository.AddAsync(maintenance);
		return Task.CompletedTask;
	}
}

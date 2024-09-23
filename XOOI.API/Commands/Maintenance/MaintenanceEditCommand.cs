using MediatR;
using XOOI.API.Data.UnitOfWork;

namespace XOOI.API.Commands.Maintenance;

public class MaintenanceEditCommand : IRequest<Task>
{
    public int Id { get; set; }
    public int VehicleId { get; set; }
    public int UserId { get; set; }
    public string Description { get; set; }
    public string MaintenanceType { get; set; }
    public string DomainSpecificExceptionsToFix { get; set; }
    public DateTime? ExpectedTimeToFix { get; set; }
    public string LocationLongitude { get; set; }
    public string LocationLatitude { get; set; }
    public DateTime ModifyDate { get; set; }
    public int ModifiedBy { get; set; }
    public bool IsDeleted { get; set; }
}

public class MaintenanceEditCommandHandler : IRequestHandler<MaintenanceEditCommand, Task>
{
    private readonly IUnitOfWork _unitOfWork;

    public MaintenanceEditCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Task> Handle(MaintenanceEditCommand request, CancellationToken cancellationToken)
    {
        var maintenanceRepository = _unitOfWork.GetRepository<Entities.Maintenance>();
        var maintenance = await maintenanceRepository.GetAsync(x => x.ID == request.Id);
        maintenance.Modify(request.ModifiedBy, request.Description, request.LocationLongitude, request.LocationLatitude);
        return Task.CompletedTask;
    }
}

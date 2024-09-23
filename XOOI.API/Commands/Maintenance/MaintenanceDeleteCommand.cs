using MediatR;
using XOOI.API.Data.UnitOfWork;

namespace XOOI.API.Commands.Maintenance;

public class MaintenanceDeleteCommand : IRequest<Task>
{
    public int Id { get; set; }

    public MaintenanceDeleteCommand(int id)
    {
        Id = id;
    }
}

public class MaintenanceDeleteCommandHandler : IRequestHandler<MaintenanceDeleteCommand, Task>
{
    private readonly IUnitOfWork _unitOfWork;

    public MaintenanceDeleteCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Task> Handle(MaintenanceDeleteCommand request, CancellationToken cancellationToken)
    {
        var maintenanceRepository = _unitOfWork.GetRepository<Entities.Maintenance>();
        var maintenance = await maintenanceRepository.GetAsync(x=>x.ID == request.Id);
        maintenance.Delete(maintenance.UserID);
        return Task.CompletedTask;
    }
}
using MediatR;
using XOOI.API.Data.UnitOfWork;

namespace XOOI.API.Queries.Maintenance;

public class GetMaintenancesByIdQuery : IRequest<Entities.Maintenance>
{
    public int Id { get; set; }
}

public class GetMaintenancesByIdQueryHandler : IRequestHandler<GetMaintenancesByIdQuery, Entities.Maintenance>
{
	private readonly IUnitOfWork _unitOfWork;

	public GetMaintenancesByIdQueryHandler(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;
	}

	public async Task<Entities.Maintenance> Handle(GetMaintenancesByIdQuery request, CancellationToken cancellationToken)
	{
		var maintenanceRepository = _unitOfWork.GetRepository<Entities.Maintenance>();
		var maintenances = await maintenanceRepository.GetAsync(x => x.ID == request.Id);
		return maintenances;
	}
}

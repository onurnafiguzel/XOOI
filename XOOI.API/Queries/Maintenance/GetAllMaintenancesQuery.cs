using MediatR;
using XOOI.API.Data.UnitOfWork;

namespace XOOI.API.Queries.Maintenance;

public class GetAllMaintenancesQuery : IRequest<List<Entities.Maintenance>>
{
}

public class GetAllMaintenancesQueryHandler : IRequestHandler<GetAllMaintenancesQuery, List<Entities.Maintenance>>
{
    private readonly IUnitOfWork _unitOfWork;
    
    public GetAllMaintenancesQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<List<Entities.Maintenance>> Handle(GetAllMaintenancesQuery request, CancellationToken cancellationToken)
    {
        var maintenanceRepository =  _unitOfWork.GetRepository<Entities.Maintenance>();
        var maintenances = await maintenanceRepository.GetAllAsync();
		return maintenances.ToList();
    }
}

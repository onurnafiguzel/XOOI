using MediatR;
using Microsoft.AspNetCore.Mvc;
using XOOI.API.Commands.Maintenance;
using XOOI.API.Queries.Maintenance;

namespace XOOI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MaintenanceController : ControllerBase
    {
        private readonly IMediator mediator;

        public MaintenanceController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET: api/Maintenance
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllMaintenancesQuery();
            var result = await mediator.Send(query);
            return Ok(result);
        }

        //// GET: api/Maintenance/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetById(int id)
        //{
           
            
        //}

        //// POST: api/Maintenance
        //[HttpPost]
        //public async Task<IActionResult> Create([FromBody] MaintenanceCreateDto maintenanceDto)
        //{
           
        //}

        //// PUT: api/Maintenance/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Edit(int id, [FromBody] MaintenanceEditDto maintenanceDto)
        //{
        //}

        //// DELETE: api/Maintenance/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
           
        //}
    }
}


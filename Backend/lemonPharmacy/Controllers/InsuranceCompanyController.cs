using lemonPharmacy.ApplicationLayer.Handlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace lemonPharmacy.API.Controllers
{
    public class InsuranceCompanyController: ApiBaseController
    {
        private readonly IMediator _mediator;
        public InsuranceCompanyController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // POST api/<InsuranceCompanyController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateInsuranceCompanyCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}

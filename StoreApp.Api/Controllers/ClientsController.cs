using MediatR;
using Microsoft.AspNetCore.Mvc;
using StoreApp.Api.Controllers.Common;
using StoreApp.Application.Features.Clients.Get;

namespace StoreApp.Api.Controllers;


public class ClientsController:BaseController
{
    private readonly IMediator _mediator;

    public ClientsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("get-customers-by-birthday")]
    public async Task<ActionResult> GetCustomersByBirthday([FromQuery]DateOnly date, CancellationToken cancellationToken)
    {
        var customers = await _mediator.Send(new GetClientsByBirthdayRequest(){ Birthday = date}, cancellationToken);
        return Ok(customers);
    }
}
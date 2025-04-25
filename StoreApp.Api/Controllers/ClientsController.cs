using MediatR;
using Microsoft.AspNetCore.Mvc;
using StoreApp.Api.Controllers.Common;
using StoreApp.Application.Features.Clients.Get;
using StoreApp.Application.Features.Clients.Get.GetClientsPopularCategories;
using StoreApp.Application.Features.Products.Get;

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
    
    [HttpGet("get-recent-customers-by-period")]
    public async Task<ActionResult> GetCustomersByBirthday([FromQuery]int period, CancellationToken cancellationToken)
    {
        var customers = await _mediator.Send(new GetClientsByRecentPurchasesRequest(){ Period = period}, cancellationToken);
        return Ok(customers);
    }

    [HttpGet("users/{id:guid}/popular-categories")]
    public async Task<ActionResult> GetClientsPopularCategories(Guid id, CancellationToken cancellationToken)
    {
        var categories = await _mediator.Send(new GetClientsPopularCategoriesRequest(){Id = id});
        if(categories == null)
            return NotFound();
        
        return Ok(categories);
    }
}
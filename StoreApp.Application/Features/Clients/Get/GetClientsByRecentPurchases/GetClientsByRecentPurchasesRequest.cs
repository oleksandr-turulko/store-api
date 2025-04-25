using MediatR;

namespace StoreApp.Application.Features.Products.Get;

public class GetClientsByRecentPurchasesRequest: IRequest<IEnumerable<GetClientsByRecentPurchasesResponse>>
{
    public int Period { get; set; }
}
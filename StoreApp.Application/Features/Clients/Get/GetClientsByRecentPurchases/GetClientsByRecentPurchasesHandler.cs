using AutoMapper;
using MediatR;
using StoreApp.Application.Features.Clients.Get.Common;
using StoreApp.Application.Repository.Clients;

namespace StoreApp.Application.Features.Products.Get;

public class GetClientsByRecentPurchasesHandler:BaseClientRequestHandler, IRequestHandler<GetClientsByRecentPurchasesRequest, IEnumerable<GetClientsByRecentPurchasesResponse>>
{
    public GetClientsByRecentPurchasesHandler(IClientsRepository clientsRepository, IMapper mapper):base(clientsRepository, mapper)
    { }

    public async Task<IEnumerable<GetClientsByRecentPurchasesResponse>> Handle(GetClientsByRecentPurchasesRequest request, CancellationToken cancellationToken)
    {
        return  await _clientsRepository.GetClientsByRecentPurchasesAsync(request.Period, cancellationToken);
    }
}
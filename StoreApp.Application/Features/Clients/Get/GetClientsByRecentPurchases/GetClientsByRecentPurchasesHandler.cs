using AutoMapper;
using MediatR;
using StoreApp.Application.Repository.Clients;

namespace StoreApp.Application.Features.Products.Get;

public class GetClientsByRecentPurchasesHandler:IRequestHandler<GetClientsByRecentPurchasesRequest, IEnumerable<GetClientsByRecentPurchasesResponse>>
{
    private readonly IMapper _mapper;
    private readonly IClientsRepository _clientsRepository;

    public GetClientsByRecentPurchasesHandler(IClientsRepository clientsRepository, IMapper mapper)
    {
        _clientsRepository = clientsRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<GetClientsByRecentPurchasesResponse>> Handle(GetClientsByRecentPurchasesRequest request, CancellationToken cancellationToken)
    {
        return  await _clientsRepository.GetClientsByRecentPurchasesAsync(request.Period, cancellationToken);
    }
}
using AutoMapper;
using MediatR;
using StoreApp.Application.Features.Clients.Get.Common;
using StoreApp.Application.Repository.Clients;

namespace StoreApp.Application.Features.Clients.Get;

public class GetClientsByBirthdayHandler:BaseClientRequestHandler, IRequestHandler<GetClientsByBirthdayRequest, IEnumerable<GetClientsByBirthdayResponse>>
{
    public GetClientsByBirthdayHandler(IClientsRepository clientsRepository, IMapper mapper):base(clientsRepository, mapper)
    { }

    public async Task<IEnumerable<GetClientsByBirthdayResponse>> Handle(GetClientsByBirthdayRequest request,
        CancellationToken cancellationToken)
    {
        return  await _clientsRepository.GetClientsByBirthdayAsync(request.Birthday);
    }
    
}
using AutoMapper;
using MediatR;
using StoreApp.Application.Repository.Clients;

namespace StoreApp.Application.Features.Clients.Get;

public class GetClientsByBirthdayHandler:IRequestHandler<GetClientsByBirthdayRequest, IEnumerable<GetClientsByBirthdayResponse>>
{
    private readonly IMapper _mapper;
    private readonly IClientsRepository _clientsRepository;

    public GetClientsByBirthdayHandler(IClientsRepository clientsRepository, IMapper mapper)
    {
        _clientsRepository = clientsRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<GetClientsByBirthdayResponse>> Handle(GetClientsByBirthdayRequest request,
        CancellationToken cancellationToken)
    {
        return  await _clientsRepository.GetClientsByBirthdayAsync(request.Birthday);
    }
    
}
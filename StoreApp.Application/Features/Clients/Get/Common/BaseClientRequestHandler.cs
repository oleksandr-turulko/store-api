using AutoMapper;
using StoreApp.Application.Repository.Clients;

namespace StoreApp.Application.Features.Clients.Get.Common;

public abstract class BaseClientRequestHandler
{
    protected readonly IMapper _mapper;
    protected readonly IClientsRepository _clientsRepository;

    protected BaseClientRequestHandler(IClientsRepository clientsRepository, IMapper mapper)
    {
        _clientsRepository = clientsRepository;
        _mapper = mapper;
    }

}
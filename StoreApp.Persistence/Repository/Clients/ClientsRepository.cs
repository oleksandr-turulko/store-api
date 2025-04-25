using StoreApp.Application.Repository.Clients;
using StoreApp.Core.Entities;
using StoreApp.Persistence.Context;

namespace StoreApp.Persistence.Repository.Clients;

public class ClientsRepository: BaseRepository<Client>, IClientsRepository
{
    public ClientsRepository(StoreAppDbContext context) : base(context)
    { }
    
}
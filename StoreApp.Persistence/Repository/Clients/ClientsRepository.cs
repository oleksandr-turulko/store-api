using Microsoft.EntityFrameworkCore;
using StoreApp.Application.Features.Clients.Get;
using StoreApp.Application.Repository.Clients;
using StoreApp.Core.Entities;
using StoreApp.Persistence.Context;

namespace StoreApp.Persistence.Repository.Clients;

public class ClientsRepository: BaseRepository<Client>, IClientsRepository
{
    public ClientsRepository(StoreAppDbContext context) : base(context)
    { }

    public async Task<IEnumerable<GetClientsByBirthdayResponse>> GetClientsByBirthdayAsync(DateOnly requestBirthday) =>  
        _context.Clients.Where(c=>c.DateOfBirth == requestBirthday)                                                    
            .Select(c=> new GetClientsByBirthdayResponse() {
                                                        ClientId = c.Id,
                                                        FirstName = c.FirstName,
                                                        LastName = c.LastName,
                                                        MiddleName = c.MiddleName,
                                                        Birthday = c.DateOfBirth
                                                    }).AsEnumerable();
        
    
}
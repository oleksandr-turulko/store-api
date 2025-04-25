using StoreApp.Application.Features.Clients.Get;
using StoreApp.Core.Entities;

namespace StoreApp.Application.Repository.Clients;

public interface IClientsRepository: IBaseRepository<Client>
{
    Task<IEnumerable<GetClientsByBirthdayResponse>> GetClientsByBirthdayAsync(DateOnly requestBirthday);
}
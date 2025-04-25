using StoreApp.Application.Features.Clients.Get;
using StoreApp.Application.Features.Clients.Get.GetClientsPopularCategories;
using StoreApp.Application.Features.Products.Get;
using StoreApp.Core.Entities;

namespace StoreApp.Application.Repository.Clients;

public interface IClientsRepository: IBaseRepository<Client>
{
    Task<IEnumerable<GetClientsByBirthdayResponse>> GetClientsByBirthdayAsync(DateOnly requestBirthday);
    Task<IEnumerable<GetClientsByRecentPurchasesResponse>> GetClientsByRecentPurchasesAsync(int period, CancellationToken cancellationToken);
    Task<List<GetClientsPopularCategoryResponse>> GetClientsPopularCategoryResponseAsync(Guid userId, CancellationToken cancellationToken);
}
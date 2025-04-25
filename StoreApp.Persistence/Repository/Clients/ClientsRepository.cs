using Microsoft.EntityFrameworkCore;
using StoreApp.Application.Features.Clients.Get;
using StoreApp.Application.Features.Clients.Get.GetClientsPopularCategories;
using StoreApp.Application.Features.Products.Get;
using StoreApp.Application.Repository.Clients;
using StoreApp.Core.Entities;
using StoreApp.Persistence.Context;

namespace StoreApp.Persistence.Repository.Clients;

public class ClientsRepository : BaseRepository<Client>, IClientsRepository
{
    public ClientsRepository(StoreAppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<GetClientsByBirthdayResponse>> GetClientsByBirthdayAsync(DateOnly requestBirthday) =>
        _context.Clients.Where(c => c.DateOfBirth == requestBirthday)
            .Select(c => new GetClientsByBirthdayResponse()
            {
                ClientId = c.Id,
                FullName = c.ToString(),
                Birthday = c.DateOfBirth
            }).AsEnumerable();

    public async Task<IEnumerable<GetClientsByRecentPurchasesResponse>> GetClientsByRecentPurchasesAsync(
        int period, CancellationToken cancellationToken)
    {
        var today = DateOnly.FromDateTime(DateTime.Now);
    
        return _context.Clients
            .Include(c => c.Purchases)
            .Where(c => c.Purchases.Any())
            .AsEnumerable()
            .Where(c => 
                (today.DayNumber - c.Purchases
                    .OrderByDescending(p => p.PurchaseDate)
                    .Last()
                    .PurchaseDate.DayNumber) < period)
            .Select(c => new GetClientsByRecentPurchasesResponse()
            {
                Id = c.Id,
                FullName = c.ToString(),
                LastPurchaseDate = c.Purchases.OrderByDescending(p => p.PurchaseDate).Last().PurchaseDate
            }).AsEnumerable();
    }
    public async Task<List<GetClientsPopularCategoryResponse>> GetClientsPopularCategoryResponseAsync(Guid userId, CancellationToken cancellationToken)
    {
        var clientExists = await _context.Clients.AnyAsync(c => c.Id == userId, cancellationToken);

        if (!clientExists)
            return null;

        var result = await _context.PurchaseItems
            .Where(pi => pi.Purchase.ClientId == userId)
            .GroupBy(pi => pi.Product.Category)
            .Select(g => new GetClientsPopularCategoryResponse
            {
                Name = g.Key,
                PurchasesCount =  g.Sum(pi => pi.Quantity)
            })
            .ToListAsync(cancellationToken);

        return result;
    }

}
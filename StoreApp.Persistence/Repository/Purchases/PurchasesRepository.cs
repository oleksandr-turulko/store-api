using StoreApp.Application.Repository.Purchases;
using StoreApp.Core.Entities;
using StoreApp.Persistence.Context;

namespace StoreApp.Persistence.Repository.Purchases;

public class PurchasesRepository:BaseRepository<Purchase>, IPurchasesRepository
{
    public PurchasesRepository(StoreAppDbContext context):base(context)
    {
    }
}
using StoreApp.Application.Repository.Products;
using StoreApp.Persistence.Context;

namespace StoreApp.Persistence.Repository.Products;

public class ProductsRepository:BaseRepository<Product>, IProductsRepository
{
    public ProductsRepository(StoreAppDbContext context):base(context)
    { }
}
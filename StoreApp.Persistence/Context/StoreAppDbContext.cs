using Microsoft.EntityFrameworkCore;

namespace StoreApp.Persistence.Context;

public class StoreAppDbContext : DbContext
{
    public StoreAppDbContext(DbContextOptions<StoreAppDbContext> options):base(options)
    { }
}
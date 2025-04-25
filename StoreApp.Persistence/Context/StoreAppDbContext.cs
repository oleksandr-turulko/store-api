using Microsoft.EntityFrameworkCore;
using StoreApp.Core.Entities;

namespace StoreApp.Persistence.Context;

public class StoreAppDbContext : DbContext
{
    public StoreAppDbContext(DbContextOptions<StoreAppDbContext> options):base(options)
    { }

    public DbSet<Client> Clients { get; set; }
}
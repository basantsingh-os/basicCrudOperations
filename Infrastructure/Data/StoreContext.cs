using Core;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
       public StoreContext(DbContextOptions<StoreContext> options): base(options)
       {
           
       }
       public DbSet<Company> Companys { get; set; }
    }
}
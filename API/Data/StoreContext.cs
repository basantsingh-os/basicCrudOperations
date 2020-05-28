using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : DbContext
    {
       public StoreContext(DbContextOptions<StoreContext> options): base(options)
       {
           
       }
       public DbSet<Company> Companys { get; set; }
    }
}
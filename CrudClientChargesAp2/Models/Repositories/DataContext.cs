using CrudClientChargesAp2.Models.Domains;
using Microsoft.EntityFrameworkCore;

namespace CrudClientChargesAp2.Models.Repositories
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts)
            :base(opts)
        {}

        public DbSet<Client> Clients { get; set; }

        public DbSet<Charge> Charges { get; set; }
    }
}
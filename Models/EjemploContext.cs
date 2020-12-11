using Microsoft.EntityFrameworkCore;

namespace EjemploApi.Models
{
    public class EjemploContext : DbContext
    {
        public EjemploContext(DbContextOptions<EjemploContext> options)
           : base(options)
        {
        }

        public DbSet<EjemploItem> EjemploItems { get; set; }
    }

}

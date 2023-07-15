using FBProductos.Models;
using Microsoft.EntityFrameworkCore;

namespace FBProductos
{
    public class AplicationDbContext: DbContext
    {
         public DbSet<Producto> Producto { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
    }
}

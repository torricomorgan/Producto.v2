using System.Data.Entity;

namespace ProductoBackend.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ProductoBackend.Models.Producto> Productoes { get; set; }
    }
}
using System.Data.Entity;

namespace APIv2.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<APIv2.Models.Product> Products { get; set; }
    }
}
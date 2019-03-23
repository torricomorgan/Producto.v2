
namespace APIv2.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        [Key]
        public int ProductoID { get; set; }
        [Required]
        [Display(Name = "Nombre del Producto")]
        public string Nombre { get; set; }
        public double Precio { get; set; }
    }
}
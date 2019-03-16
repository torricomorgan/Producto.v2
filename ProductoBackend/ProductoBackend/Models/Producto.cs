using System.ComponentModel.DataAnnotations;

namespace ProductoBackend.Models
{
    public class Producto
    {
        [Key]
        public int ProductoID { get; set; }
        [Required]
        [Display(Name="Nombre del Producto")]
        public string Nombre { get; set; }
        public double Precio { get; set; }
    }
}
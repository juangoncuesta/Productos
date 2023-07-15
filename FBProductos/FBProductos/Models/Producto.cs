using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace FBProductos.Models
{
    public class Producto
    {
        
        public int Id { get; set; }
        [Required]
        public string Codigo { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public decimal Precio_venta { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public string imagen { get; set; }
        [Required]
        public int estado { get; set;}
        

    }
}

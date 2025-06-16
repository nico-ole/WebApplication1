using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplication1.Models

{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage= "El nombre de categoria es obligatorio")]
        public string NombreCategoria {  get; set; }
        [Required(ErrorMessage = "El Orden es obligatorio")]
        [Range(1,int.MaxValue, ErrorMessage= "El orden debe ser mayor a cero")]
        public int Orden { get; set; }
        [Required(ErrorMessage = "La descripcion es obligatoria")]
        public string Descripcion { get; set; }
    }
}

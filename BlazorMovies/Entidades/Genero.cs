using BlazorMovies.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace BlazorMovies.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El campo {0} es requerido")]
        [PrimeraLetraMayuscula]
        public string? Nombre { get; set; }
    }
}

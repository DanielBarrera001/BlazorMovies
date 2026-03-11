namespace BlazorMovies.Entidades;

public class Pelicula
{
    public int Id { get; set; } 
    public required string Titulo { get; set; }
    public DateTime FechaLanzamiento { get; set; }
}

using BlazorMovies.Entidades;

namespace BlazorMovies.Servicios
{
    public interface IServicioPeliculas
    {
        List<Pelicula> ObtenerPeliculas();
    }
}

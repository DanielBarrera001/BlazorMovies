using BlazorMovies.Entidades;

namespace BlazorMovies.Servicios
{
    public class ServicioPeliculasEnMemoria : IServicioPeliculas
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>
            {
            new Pelicula
            {
                Id = 1,
                Titulo = "Interestelar",
                FechaLanzamiento = new DateTime(2010,2,14)
            },
            new Pelicula
            {
                Id = 2,
                Titulo = "Interestelar 2",
                FechaLanzamiento = new DateTime(2020,2,14)
            }};
        }
    }
}

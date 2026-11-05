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
                FechaLanzamiento = new DateTime(2020,2,14),
                PosterURL = "https://upload.wikimedia.org/wikipedia/commons/b/b2/Interstellar-logo.jpg?utm_source=es.wikipedia.org&utm_campaign=imageinfo&utm_content=thumbnail_unscaled"
            },
            new Pelicula
            {
                Id = 2,
                Titulo = "Interestelar 2",
                FechaLanzamiento = new DateTime(2020,2,14),
                PosterURL = "https://upload.wikimedia.org/wikipedia/commons/b/b2/Interstellar-logo.jpg?utm_source=es.wikipedia.org&utm_campaign=imageinfo&utm_content=thumbnail_unscaled"

            }};
        }
    }
}

using BibliotecaDigital.Models;

namespace BibliotecaDigital.Services
{
    public class LibroService : ILibroService
    {
        public List<Libro> ObtenerLibrosMockup()
        {
            return new List<Libro>
            {
                new Libro { Id = 1, Titulo = "Cien años de soledad", Genero = "Novela", PrecioAlquiler = 2.50m, Disponible = true },
                new Libro { Id = 2, Titulo = "El Principito", Genero = "Infantil", PrecioAlquiler = 1.80m, Disponible = true },
                new Libro { Id = 3, Titulo = "Breve historia del tiempo", Genero = "Divulgación", PrecioAlquiler = 2.20m, Disponible = false },
                new Libro { Id = 4, Titulo = "Don Quijote de la Mancha", Genero = "Clásico", PrecioAlquiler = 3.00m, Disponible = true }
            };
        }
    }
}

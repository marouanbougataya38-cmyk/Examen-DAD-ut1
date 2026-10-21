namespace BibliotecaDigital.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public decimal PrecioAlquiler { get; set; }
        public bool Disponible { get; set; }
    }
}

using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using BibliotecaDigital.Models;
using BibliotecaDigital.Services;

namespace BibliotecaDigital.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly ILibroService _libroService;

        [ObservableProperty]
        private ObservableCollection<Libro> _libros = new();

        [ObservableProperty]
        private List<string> _generos = new() { "Novela", "Clásico", "Infantil", "Divulgación", "Ciencia Ficción" };

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(AgregarLibroCommand))]
        private string _nuevoTitulo = string.Empty;

        [ObservableProperty]
        private string _nuevoGenero = "Novela";

        [ObservableProperty]
        private decimal _nuevoPrecio = 2.00m;

        [ObservableProperty]
        private bool _nuevoDisponible = true;

        [ObservableProperty]
        private Libro? _libroSeleccionado;

        public MainViewModel(ILibroService libroService)
        {
            _libroService = libroService;
            CargarDatos();
        }

        private void CargarDatos()
        {
            var datos = _libroService.ObtenerLibrosMockup();
            Libros = new ObservableCollection<Libro>(datos);
        }

        private bool CanAgregarLibro => !string.IsNullOrWhiteSpace(NuevoTitulo);

        [RelayCommand(CanExecute = nameof(CanAgregarLibro))]
        private void AgregarLibro()
        {
            var nuevo = new Libro
            {
                Id = Libros.Count + 1,
                Titulo = NuevoTitulo,
                Genero = NuevoGenero,
                PrecioAlquiler = NuevoPrecio,
                Disponible = NuevoDisponible
            };

            Libros.Add(nuevo);

            NuevoTitulo = string.Empty;
        }
    }
}

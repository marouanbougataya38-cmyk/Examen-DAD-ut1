using System.Windows;
using BibliotecaDigital.Services;
using BibliotecaDigital.ViewModels;

namespace BibliotecaDigital.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ILibroService servicio = new LibroService();
            DataContext = new MainViewModel(servicio);
        }
    }
}

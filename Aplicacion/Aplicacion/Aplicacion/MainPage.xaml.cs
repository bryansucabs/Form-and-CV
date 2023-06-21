using Aplicacion.vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicacion
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            DatePicker.Date = DateTime.Today;
        }
        private async void EnviarButton_Clicked(object sender, EventArgs e)
        {
            // Obtener los valores de los controles en MainPage
            string nombre = NombreEntry.Text;
            string apellidos = ApellidosEntry.Text;
            string fechaNacimiento = DatePicker.Date.ToString("dd/MM/yyyy");
            string ocupacion = OcupacionEntry.Text;
            string telefono = TelefonoEntry.Text;
            string email = EmailEntry.Text;
            string nacionalidad = NacionalidadPicker.SelectedItem?.ToString();
            string nivelIngles = ObtenerNivelIngles();
            string lenguajeProgramacion = LenguajesPicker.SelectedItem?.ToString();
            //string aptitudes = AptitudesEntry.Text;
            bool rapidez = RapidezCheckBox.IsChecked;
            bool creatividad = CreatividadCheckBox.IsChecked;
            bool ingenio = IngenioCheckBox.IsChecked;
            bool intuitivo = IntuitivoCheckBox.IsChecked;
            string perfil = PerfilEditor.Text;

            // Pasar los datos a CVPage y navegar a esa página
            CVPage cvPage = new CVPage(nombre, apellidos, fechaNacimiento, ocupacion, telefono, email, nacionalidad, nivelIngles, lenguajeProgramacion, rapidez, creatividad, ingenio, intuitivo, perfil);
            await Navigation.PushAsync(cvPage);
        }

        private string ObtenerNivelIngles()
        {
            if (BasicoRadioButton.IsChecked)
                return "Básico";
            else if (IntermedioRadioButton.IsChecked)
                return "Intermedio";
            else if (AvanzadoRadioButton.IsChecked)
                return "Avanzado";
            else if (FluidoRadioButton.IsChecked)
                return "Fluido";
            else
                return string.Empty;
        }
    }
}

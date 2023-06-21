using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicacion.vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CVPage : ContentPage
    {
        public CVPage(string nombre, string apellidos, string fechaNacimiento, string ocupacion, string telefono, string email, string nacionalidad, string nivelIngles, string lenguajeProgramacion, bool rapidez, bool creatividad, bool ingenio, bool intuitivo, string perfil)
        {
            InitializeComponent();

            // Utiliza los datos recibidos para mostrar la información en la página
            MostrarDatos(nombre, apellidos, fechaNacimiento, ocupacion, telefono, email, nacionalidad, nivelIngles, lenguajeProgramacion, rapidez, creatividad, ingenio, intuitivo, perfil);
        }

        private void MostrarDatos(string nombre, string apellidos, string fechaNacimiento, string ocupacion, string telefono, string email, string nacionalidad, string nivelIngles, string lenguajeProgramacion, bool rapidez, bool creatividad, bool ingenio, bool intuitivo, string perfil)
        {
            // Mostrar los datos en los elementos de la página
            NombreLabel.Text = nombre;
            ApellidosLabel.Text = apellidos;
            FechaNacimientoLabel.Text = fechaNacimiento;
            OcupacionLabel.Text = ocupacion;
            TelefonoLabel.Text = telefono;
            EmailLabel.Text = email;
            NacionalidadLabel.Text = nacionalidad;
            NivelInglesLabel.Text = nivelIngles;
            LenguajesProgramacionLabel.Text = lenguajeProgramacion;
            //AptitudesLabel.Text = aptitudes;
            RapidezLabel.Text = rapidez ? "Sí" : "No";
            CreatividadLabel.Text = creatividad ? "Sí" : "No";
            IngenioLabel.Text = ingenio ? "Sí" : "No";
            IntuitivoLabel.Text = intuitivo ? "Sí" : "No";
            PerfilLabel.Text = perfil;
        }
    }
}

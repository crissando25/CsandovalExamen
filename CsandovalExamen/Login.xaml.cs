using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CsandovalExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2023";
            string contrasena = "uisrael2023";
            string Usu = TxtUsuario.Text;
            string Contra = TxtContrasena.Text;



            if (usuario == Usu & contrasena == Contra)


            {
                DisplayAlert("Alerta", "\nUSUARIO CORRECTO", "\nCerrar");
                await Application.Current.MainPage.Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                DisplayAlert("Alerta", "USUARIO NO EXISTE", "Cerrar");

            }
        }
    }
}
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
    public partial class Registro : ContentPage
    {
        public Registro()
        {
        }

        public Registro(string usuario)
        {
            InitializeComponent();
        }


        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            String apellido = TxtApellido.Text;
            double monto = Convert.ToDouble(TxtMonto1.Text);
            var Monto1 = double.Parse(TxtMonto1.Text);
            
            var Calcular = (Monto1*3) - Monto1;
            var Calcular1 = (Calcular *0.05)*3+ Monto1*3;
            var Pmensual = (Calcular1 + monto);
            TxtPmensual.Text = Pmensual.ToString();
            //Txttotal.Text = Pmensual.ToString();
            await Application.Current.MainPage.Navigation.PushAsync(new Resumen(nombre, apellido));

            {
                DisplayAlert("Elemento", "Guardado con exito", "Cerrar");
                Navigation.PushAsync(new Registro());
            }
        }

        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            //limpiar todos los datos de la pantalla

            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtMonto1.Text = "";
            
            
        }

    }
}
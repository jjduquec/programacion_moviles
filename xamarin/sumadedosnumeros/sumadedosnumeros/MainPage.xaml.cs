using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace sumadedosnumeros
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            try
            {
                float a = float.Parse(valorA.Text);
                float b = float.Parse(ValorB.Text);
                float c = a + b;
                Resultado.Text = a + "+" + b + "=" + c;
            }
            catch (Exception) {


                Resultado.Text = "Datos Erroneos, porfavor intentelo nuevamente ";
            
            }

        }
    }
}

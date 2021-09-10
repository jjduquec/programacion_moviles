using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadoraconpickers
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try {

                float a = float.Parse(valorA.Text);
                float b = float.Parse(valorB.Text);
                float c=0;

                switch (operacion.SelectedItem.ToString()) {

                    case "Suma":

                        c = a + b;
                        break;
                    case "Resta":
                        c = a - b;
                        break;
                    case "Multiplicacion":
                        c = a * b;
                        break;
                    case "Division":
                        c = a / b;
                        break; 
                
                }
                resultado.Text = c.ToString();
            } catch (Exception ) {

                resultado.Text = "Operacion no valida, porfavor intente de nuevo";
            
            
            }
        }
    }
}

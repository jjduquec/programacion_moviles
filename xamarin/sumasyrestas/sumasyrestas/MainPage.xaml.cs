using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace sumasyrestas
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

                float a = float.Parse(valorA.Text); //recolectamos primer valor 
                float b = float.Parse(valorB.Text); //recolectamos el segundo valor  
                float c; //definimos la variable en la que mostraremos el resultado  

                // a travez de un switch case definimos la operacion a efectuar  
                switch (operacion.SelectedIndex) {

                    case 0:
                        //efectuamos suma  
                        c = a + b;
                        resultado.Text = a + "+" + b + "=" + c;
                        break;
                    case 1:
                        //efectuamos resta 
                        c = a - b;
                        resultado.Text = a + "+" + b + "=" + c;
                        break;

                    case 2:
                        //efectuamos multiplicacion 
                        c = a * b;
                        resultado.Text = a + "+" + b + "=" + c;
                        break;
                    case 3:
                        //efectuamos division
                        c = a / b;
                        resultado.Text = a + "+" + b + "=" + c;
                        break;

                    default:
                        resultado.Text = "No ha seleccionado alguna opcion, porfavor intentelo nuevamente";
                        break;




                }


            } catch (Exception) {


                resultado.Text = "Datos Erroneos, porfavor intentelo de nuevo ";


            }
        }
    }
}

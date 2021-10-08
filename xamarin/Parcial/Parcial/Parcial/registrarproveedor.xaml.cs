using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registrarproveedor : ContentPage
    {


        class Proveedor { 
        
        public string Nombre { set; get; }

        public string Direccion { set; get; }

        public string Colonia { set; get; }

        public string Municipio { set; get; }

        public string Telefono { set; get; }

        public string Correo { set; get; }
    
        public string Foto { set; get; }

        public string Password { set; get; }

        public string Medio_pago { set; get; }


        public string Oferta { set; get; }

        public string Nombre_negocio { set; get; }
        public string Categoria_negocio { set; get; }

        public string Logo_negocio { set; get; }


        









        }
        public registrarproveedor()
        {
            InitializeComponent();
        }





        public void enviar(object sender, EventArgs e ) {
            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
            string path_bd = System.IO.Path.Combine(folder, "Aplicativo.db");
            var db = new SQLiteConnection(path_bd); //conexion bd
            //crea la tabla  en caso de que no existe   
            db.CreateTable<Proveedor>();

            var pago="";
            var oferta = "";

            if ((efectivo.IsChecked) && (electronico.IsChecked))
            {

                pago = "Acepta Efectivo y Electronico";

            }
            else if (efectivo.IsChecked)
            {
                pago = "Acepta Efectivo";

            }
            else if (electronico.IsChecked) {

                pago = "Acepta pago electronico";
            
            
            }


            if ((servicios.IsChecked) && (productos.IsChecked))
            {

                oferta = "Ofrece productos y servicios";


            }
            else if (servicios.IsChecked)
            {

                oferta = "Ofrece servicios";
            }
            else if (productos.IsChecked) {

                oferta = "Ofrece productos";

            }

            var registro_proveedor = new Proveedor
            {

                Nombre = nombre.Text,
                Direccion = direccion.Text,
                Colonia = colonia.Text,
                Municipio = municipio.Text,
                Telefono = telefono.Text,
                Correo = correo.Text,
                Foto = foto.Text,
                Password = password.Text,
                Medio_pago = pago,
                Oferta = oferta,
                Nombre_negocio = nombre_negocio.Text,
                Categoria_negocio=categoria_negocio.Text, 
                Logo_negocio=logo_negocio.Text
                





            };

            db.Insert(registro_proveedor);
            DisplayAlert("Registro Proveedor", "El proveedor ha sido registrado", "OK");



        }





    }
}
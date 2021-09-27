using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite; 
using Xamarin.Forms;

namespace Parcial
{
    public partial class MainPage : ContentPage
    {

        public class Cliente
        {

            public string Nombre { set; get; }
            public string Direccion { set; get; }
            public string Colonia { set; get; }
            public string Municipio { set; get; }
            public string Telefono { set; get; }

            public string Correo { set; get; }

            public string Foto { set; get; }

            public string Password { set; get; }


        }

        class Proveedor
        {

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
        public MainPage()
        {
            InitializeComponent();
        }

        async void iniciando_sesion_cliente() {
            await Navigation.PushAsync(new BienvenidaCliente());

        }


        async void iniciando_sesion_proveedor() {
            await Navigation.PushAsync(new BienvenidaProveedor());
        
        }

        public void inicio_sesion(object sender,EventArgs e) {

            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
            string path_bd = System.IO.Path.Combine(folder, "Aplicativo.db");
            var db = new SQLiteConnection(path_bd); //conexion bd 



            if (cliente.IsChecked)
            {

                cliente.IsChecked = false;

                //selecciono el rol cliente  
                var clientes = db.Query<Cliente>("SELECT * FROM Cliente WHERE Nombre=?", nombre.Text);
                var pasa = false;
                foreach (var x in clientes)
                {

                    if (x.Password == password.Text)
                    {
                        pasa = true;

                    }


                }


                if (pasa)
                {
                    nombre.Text = "";
                    password.Text = "";
                    iniciando_sesion_cliente();

                }
                else
                {

                    nombre.Text = "";
                    password.Text = "";



                }


            }
            else if (proveedor.IsChecked) {
                proveedor.IsChecked = false;


                //selecciono el rol cliente  
                var proveedores = db.Query<Proveedor>("SELECT * FROM Proveedor WHERE Nombre=?", nombre.Text);
                var pasa = false;
                foreach (var x in proveedores)
                {

                    if (x.Password == password.Text)
                    {
                        pasa = true;

                    }


                }


                if (pasa)
                {
                    nombre.Text = "";
                    password.Text = "";
                    iniciando_sesion_proveedor();

                }
                else
                {

                    nombre.Text = "";
                    password.Text = "";



                }
















            } 




        }//iniciar sesion 


        async void registrando_cliente() {

            await Navigation.PushAsync(new registrarcliente());

        }
        public void registrar_cliente(object sender, EventArgs e)
        {

            registrando_cliente();


        } 





        async void registrar_proveedor(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new registrarproveedor());



        }




    }

    







}

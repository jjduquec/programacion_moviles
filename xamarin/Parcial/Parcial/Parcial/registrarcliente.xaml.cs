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
    public partial class registrarcliente : ContentPage
    {


        public class Cliente { 
        
            public string Nombre { set; get; }  
            public string Direccion { set; get; } 
            public string Colonia { set; get; } 
            public string Municipio { set; get; } 
            public string Telefono { set; get; } 

            public string Correo { set; get; } 

            public string Foto { set; get; } 

            public string Password { set; get; } 

        
        }
        public registrarcliente()
        {
            InitializeComponent();
        }


        public void registrar(object sender, EventArgs e) {
            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
            string path_bd = System.IO.Path.Combine(folder, "Aplicativo.db");
            var db = new SQLiteConnection(path_bd); //conexion bd
            //crea la tabla  en caso de que no existe   
            db.CreateTable<Cliente>();



            //obtenemos la informacion de los campos   
            var registro_cliente = new Cliente
            {

                Nombre = nombre.Text,
                Direccion = direccion.Text,
                Colonia = colonia.Text,
                Municipio = municipio.Text,
                Telefono = telefono.Text,
                Correo = correo.Text,
                Foto = url.Text,
                Password = passw.Text


            };
            db.Insert(registro_cliente);
            DisplayAlert("Registro Cliente", "El cliente ha sido registrado", "OK");





        }


    
    
    }
}
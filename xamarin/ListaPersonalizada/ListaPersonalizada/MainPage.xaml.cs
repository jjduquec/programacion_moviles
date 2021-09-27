using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace ListaPersonalizada
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public class Fruta
        {
            public string Nombre { get; set; } 
            public string Url { get; set; }
        }

        ObservableCollection<Fruta> datos=new ObservableCollection<Fruta>();
        public MainPage()
        {
            InitializeComponent();
            milista.ItemsSource = datos;
        }

        private void Button_Clicked(object sender,System.EventArgs e)
        {
            datos.Add(new Fruta { Nombre = Valor.Text, Url = url_imagen.Text });
        }

        private void MenuItem_Mostrar(object sender, System.EventArgs e)
        {
            DisplayAlert("Mensaje", "Ha Seleccionado Mostrar", "ok");
        }


        private void MenuItem_Borrar(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("Fruta Seleccionada","Fruta:"+mi.CommandParameter.ToString(),"ok");
        }

        async private void Lista_ItemTapped(object sender, ItemTappedEventArgs e) {
            var myListView = (ListView)sender;
            var myItem = myListView.SelectedItem;

            int index = datos.IndexOf(myItem);
            string action = await DisplayActionSheet("Acciones:", "Cancelar", null, "Eliminar", "Editar");
            if (action == "Eliminar") {
                datos.RemoveAt(index);
                await DisplayAlert("Eliminar elemento", "Se elimino el elemento no:" + index, "Ok");

            
            
            }
            if (action == "Editar") {

                await DisplayAlert("Mensaje", "Selecciono Editar", "ok");
            }
            
        }


    }
}

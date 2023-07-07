using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cllullunaS6
{
    public partial class MainPage : ContentPage
    {
        private string url = "http://192.168.10.48/ws_uisrael/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<estudiante> _post;
        
        public MainPage()
        {
            InitializeComponent();
            obtener();
                
            
        }

        public async void obtener()
        {
            var contenido = await client.GetStringAsync(url);

            List<estudiante> postd = JsonConvert.DeserializeObject<List<estudiante>>(contenido);
            _post = new ObservableCollection<estudiante>(postd);
            listaestudiantes.ItemsSource = _post;
        }

            private async void btnmostrar_Clicked(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new insertarE());


        }

        private   void listaestudiantes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var objectEstudiante = (estudiante)e.SelectedItem;
            

             Navigation.PushAsync(new ActualizarEliminar(objectEstudiante));
        }
    }
}

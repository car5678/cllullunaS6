using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cllullunaS6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class ActualizarEliminar : ContentPage
    {
        private string url = "http://192.168.56.1/ws_uisrael/post.php?codigo= ";
        public ActualizarEliminar(estudiante datos)
        {
            InitializeComponent();
            txtcodigo.Text = datos.codigo.ToString();
            txtnombre.Text = datos.nombre.ToString();
            txtapellido.Text = datos.apellido.ToString();
            txtedad.Text = datos.edad.ToString();

        }

        private void btnactualizar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                var datos = new System.Collections.Specialized.NameValueCollection();

                datos.Add("nombre", txtnombre.Text);
                datos.Add("apellido", txtapellido.Text);
                datos.Add("edad", txtedad.Text);

                var parametros = txtcodigo.Text + "&nombre=" + txtnombre.Text + "&apellido=" + txtapellido.Text + "&edad=" + txtedad.Text;

                cliente.UploadValues(url + parametros, "PUT", datos);
                var mensaje = "dato actualizado con exito";

                DependencyService.Get<mensaje>().showmsg(mensaje);

                DisplayAlert("Alerta", "Dato Actualizado correctamente", "Ok");
                Navigation.PushAsync(new MainPage());

            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Ok");
            }
        }
    

        private void btneliminar_Clicked(object sender, EventArgs e)
        {

            try
            {
                WebClient cliente = new WebClient();
                var datos = new System.Collections.Specialized.NameValueCollection();
                
                datos.Add("codigo" , txtcodigo.Text);


                cliente.UploadValues(url + txtcodigo.Text, "Eliminar", datos);

                var mensaje = "dato eliminado con exito";

                DependencyService.Get<mensaje>().showmsg(mensaje);
                DisplayAlert("Alerta", "Dato Eliminado correctamente", "Ok");
                Navigation.PushAsync(new MainPage());

            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Ok");
            }
        }
    }

}
    

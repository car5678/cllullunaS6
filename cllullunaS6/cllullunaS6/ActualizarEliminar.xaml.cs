using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cllullunaS6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActualizarEliminar : ContentPage
    {
        public ActualizarEliminar(estudiante datos)
        {
            InitializeComponent();
            txtapellido.Text = datos.ToString();
            txtnombre.Text = datos.ToString();  
            txtapellido.Text= datos.ToString();
            txtedad.Text = datos.ToString();  

        }

        private void btnactualizar_Clicked(object sender, EventArgs e)
        {

        }

        private void btneliminar_Clicked(object sender, EventArgs e)
        {

        }
    }
}
﻿using System;
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
    public partial class insertarE : ContentPage
    {
        public insertarE(estudiante datos)
        {
            InitializeComponent();
        }

        private async void btninsertar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient(); 
                 var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("codigo", txtcodigo.Text);
                parametros.Add("nombre", txtnombre.Text);
                parametros.Add("apellido", txtapellido.Text);
                parametros.Add("edad", txtedad.Text);



                    client.UploadValues("http://192.168.10.48/ws_uisrael/post.php" ,"post" ,parametros);
                await DisplayAlert("alerta", "dato ingresado correctamente", "ok");

            }
            catch (Exception ) { }
        }
    }
}
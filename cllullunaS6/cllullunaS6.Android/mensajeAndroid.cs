using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using cllullunaS6.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;


[assembly: Xamarin.Forms.Dependency(typeof(mensajeAndroid))]

namespace cllullunaS6.Droid
{
    public class mensajeAndroid : mensaje
    {


        public void showAlert(string msg)


        {
            Toast.MakeText(Application.Context, msg , ToastLength.Long).Show();
           
        }

        public void showmsg(string msg)
        {
            Toast.MakeText(Application.Context, msg, ToastLength.Short).Show();

        }
    }
}
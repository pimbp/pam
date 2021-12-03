using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(LoginEntry.Text) == false && String.IsNullOrEmpty(PassEntry.Text) == false)
            {
                DisplayAlert("Alert", "Login: " + LoginEntry.Text, "OK");
            }
            else
            {
                DisplayAlert("Error", "Please input both the login and the password", "OK");
            }
        }
    }
}

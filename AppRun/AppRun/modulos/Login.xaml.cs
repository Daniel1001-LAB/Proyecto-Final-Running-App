﻿using AppRun.ViewModel;
using AppRun.modulos;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppRun
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
      
        protected override bool OnBackButtonPressed() { return true; }
        public Login()
        {
 
            BindingContext = new LoginViewModel();
                   
            InitializeComponent();
            Device.SetFlags(new string[] { "MediaElement_Experimental" });
           
        }

        private async void registro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrarUsuario());
        }

        private async void inicio_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inicio());
        }

       
        private async void ButtonForgot(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPassword());

        }
      
    }

}
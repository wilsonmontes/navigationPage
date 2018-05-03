﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace navigationPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina2 : ContentPage
	{
		public Pagina2 ()
		{
			InitializeComponent ();
            this.lbOpcion.Text = string.Empty;
            btnTres.Clicked += BtnTres_Clicked;
            btnTest.Clicked += BtnTest_Clicked;
		}

        private async void BtnTest_Clicked(object sender, EventArgs e)
        {
            this.lbOpcion.Text = string.Empty;
            var resp = await DisplayAlert("Test","Esta seguro de realizar el test","Si","No");
            if(resp)
            {
                await DisplayAlert("Inicio de Test","Super bienvenido","Aceptar");
                var opcion = await DisplayActionSheet("Opciones",
                                                        "Cancelar",
                                                        null,"Opcion 1", "Opcion 2", "opcion 3");
                lbOpcion.Text = opcion.ToString();
            }
            else
            {
                await DisplayAlert("Test Fallido","En otra ocasión sera","Aceptar");
            }
        }

        private async void BtnTres_Clicked(object sender, EventArgs e)
        {
            this.lbOpcion.Text = string.Empty;
            await Navigation.PushAsync(new Pagina3());
        }
    }
}
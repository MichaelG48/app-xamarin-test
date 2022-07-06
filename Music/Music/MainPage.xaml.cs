using Music.Entities;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Music
{
    public partial class MainPage : ContentPage
    {
        public IList<Inicio> Start { get; private set; }

        public MainPage()
        {
            InitializeComponent();

            Start = new List<Inicio>();

            //Imagen inicio
            Start.Add(new Inicio
            {
                Nombre = "Logo",
                ImagenUrl = "https://i.giphy.com/media/UGrpkMXipFWQ06IHIM/giphy.gif"
            });

            BindingContext = this;
        }

        private async void BtnArtistas_Clicked(object sender, EventArgs e)
        {
            // await Navigation.PushAsync();
            await Navigation.PushAsync(new Artistas());
        }
    }
}

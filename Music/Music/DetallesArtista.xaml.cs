using Music.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Music
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetallesArtista : ContentPage
    {
        public IList<Detalles> DetallesArtistas { get; private set; }
        public DetallesArtista()
        {
            InitializeComponent();

            DetallesArtistas = new List<Detalles>();

            //Abraham Mateo
            DetallesArtistas.Add(new Detalles
            {
                NombreArtista = "Abraham Mateo",
                ImagUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/52/Adele_for_Vogue_in_2021.png/375px-Adele_for_Vogue_in_2021.png",
                Detalle = "Detalles de Adele"
            });

            //Abraham Mateo
            DetallesArtistas.Add(new Detalles
            {
                NombreArtista = "Abraham Mateo",
                ImagUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/52/Adele_for_Vogue_in_2021.png/375px-Adele_for_Vogue_in_2021.png",
                Detalle = "Detalles de Adele"
            });

            BindingContext = this;
        }
    }
}
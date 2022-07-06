using Music.Entities;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Music
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Artistas : ContentPage
    {
        public IList<Cantante> Cantantes { get; private set; }
        public Artistas()
        {
            InitializeComponent();

            Cantantes = new List<Cantante>();

            //Abraham Mateo
            Cantantes.Add(new Cantante
            {
                Nombre = "Abraham Mateo",
                Genero = "Pop / Pop Latino",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/55/Abraham_Mateo_Mexico_2019.jpeg/398px-Abraham_Mateo_Mexico_2019.jpeg",
                Detalle = "Detalles del artista"
            });

            //Adele
            Cantantes.Add(new Cantante
            {
                Nombre = "Adele",
                Genero = "Blue - eyed soul / Pop / Pop Soul",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/52/Adele_for_Vogue_in_2021.png/375px-Adele_for_Vogue_in_2021.png",
                Detalle = "Detalles del artista"
            });

            //Alec Benjamin
            Cantantes.Add(new Cantante
            {
                Nombre = "Alec Benjamin",
                Genero = "Pop",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/86/Alec_Benjamin_Press_Photo_Atlantic.jpg/330px-Alec_Benjamin_Press_Photo_Atlantic.jpg",
                Detalle = "Detalles del artista"
            });

            //Ariana Grande
            Cantantes.Add(new Cantante
            {
                Nombre = "Ariana Grande",
                Genero = "Pop / R&B",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/Ariana_Grande_Grammys_Red_Carpet_2020.png/330px-Ariana_Grande_Grammys_Red_Carpet_2020.png",
                Detalle = "Detalles del artista"
            });

            //Beyonce
            Cantantes.Add(new Cantante
            {
                Nombre = "Beyoncé",
                Genero = "R&B / Pop / Soul / Hip Hop",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/18/Beyonc%C3%A9_Black_Is_King_Still.png/375px-Beyonc%C3%A9_Black_Is_King_Still.png",
                Detalle = "Detalles del artista"
            });

            //BillieEilish
            Cantantes.Add(new Cantante
            {
                Nombre = "Billie Eilish",
                Genero = "Pop Alternativo / Electropop / Indie Pop / Art Pop / Música Experimental",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Billie_Eilish_2019_by_Glenn_Francis_%28cropped%29_2.jpg/330px-Billie_Eilish_2019_by_Glenn_Francis_%28cropped%29_2.jpg",
                Detalle = "Detalles del artista"
            });

            //Celine Dion
            Cantantes.Add(new Cantante
            {
                Nombre = "Celine Dion",
                Genero = "Balada Romántica / Pop / Dance Pop / R&B",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/57/Celine_Dion_Concert_-_Singing_I%27m_Alive.jpg/330px-Celine_Dion_Concert_-_Singing_I%27m_Alive.jpg",
                Detalle = "Detalles del artista"
            });

            //Danna Paola
            Cantantes.Add(new Cantante
            {
                Nombre = "Danna Paola",
                Genero = "Pop Latino / Balada",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Danna_Paola_during_an_interview_in_September_2018_02.png/330px-Danna_Paola_during_an_interview_in_September_2018_02.png",
                Detalle = "Detalles del artista"
            });

            //Demi Lovato
            Cantantes.Add(new Cantante
            {
                Nombre = "Demi Lovato",
                Genero = "Pop Rock / Pop / R&B Contemporáneo",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/Demi_Lovato%2C_Future_Now_2016_%28Cropped%29.jpg/255px-Demi_Lovato%2C_Future_Now_2016_%28Cropped%29.jpg",
                Detalle = "Detalles del artista"
            });

            //Dua Lipa
            Cantantes.Add(new Cantante
            {
                Nombre = "Dua Lipa",
                Genero = "Pop / Disco / House / Dance Pop / R&B",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Dua_Lipa_with_Warner_Music.jpg/330px-Dua_Lipa_with_Warner_Music.jpg",
                Detalle = "Detalles del artista"
            });

            //Ed Sheeran
            Cantantes.Add(new Cantante
            {
                Nombre = "Ed Sheeran",
                Genero = "Pop / Folk Pop / Dance Pop",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e9/Ed_Sheeran-6826_%28cropped%29.jpg/330px-Ed_Sheeran-6826_%28cropped%29.jpg",
                Detalle = "Detalles del artista"
            });

            //HA-ASH
            Cantantes.Add(new Cantante
            {
                Nombre = "HA-ASH",
                Genero = "Balada Romántica / Country / country Pop / Electropop / Funk / Pop Latino / Pop Rock",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fb/Durante_un_concierto.jpeg/270px-Durante_un_concierto.jpeg",
                Detalle = "Detalles del artista"
            });

            //Joey Montana
            Cantantes.Add(new Cantante
            {
                Nombre = "Joey Montana",
                Genero = "Reguetón / Reggae en Español / Balada / Bachata / Romantic Flow / Pop Latino",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/0/00/Joey_Montana_en_Acceso_Total_%285306706447%29_%28cropped%29.jpg",
                Detalle = "Detalles del artista"
            });

            //Juan Gabriel
            Cantantes.Add(new Cantante
            {
                Nombre = "Juan Gabriel",
                Genero = "Mariachi / Ranchera / Bolero / Pop Latino / Balada",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1c/Juan_Gabriel%2C_c._1985_%28cropped%29.jpg/330px-Juan_Gabriel%2C_c._1985_%28cropped%29.jpg",
                Detalle = "Detalles del artista"
            });

            //Justin Bieber
            Cantantes.Add(new Cantante
            {
                Nombre = "Justin Bieber",
                Genero = "Pop / R&B / Hip Hop / Dance",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Justin_Bieber_in_2015.jpg/330px-Justin_Bieber_in_2015.jpg",
                Detalle = "Detalles del artista"
            });

            //Karol G
            Cantantes.Add(new Cantante
            {
                Nombre = "Karol G",
                Genero = "Reguetón / Pop Latino / Trap Latino",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/Karol_G_en_2018.jpg/330px-Karol_G_en_2018.jpg",
                Detalle = "Detalles del artista"
            });

            //Katy Perry
            Cantantes.Add(new Cantante
            {
                Nombre = "Katy Perry",
                Genero = "Pop / Pop Rock / Disco / Electropop / Dance Pop / Synth Pop",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5f/Katy_Perry_9_%2842287412124%29_%28cropped%29.jpg/300px-Katy_Perry_9_%2842287412124%29_%28cropped%29.jpg",
                Detalle = "Detalles del artista"
            });

            //Lady Gaga
            Cantantes.Add(new Cantante
            {
                Nombre = "Lady Gaga",
                Genero = "Pop / Rock / Electrónica / Dance / Jazz / Country",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e0/Lady_Gaga_at_Joe_Biden%27s_inauguration_%28cropped%29.jpg/330px-Lady_Gaga_at_Joe_Biden%27s_inauguration_%28cropped%29.jpg",
                Detalle = "Detalles del artista"
            });

            //Luis Miguel
            Cantantes.Add(new Cantante
            {
                Nombre = "Luis Miguel",
                Genero = "Funk / Pop Latino / Pop / Bolero / Mariachi",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/57/Luis_Miguel.jpg/330px-Luis_Miguel.jpg",
                Detalle = "Detalles del artista"
            });

            //Madonna
            Cantantes.Add(new Cantante
            {
                Nombre = "Madonna",
                Genero = "Pop / Electrónica / Dance",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/Madonna_Rebel_Heart_Tour_2015_-_Stockholm_%2823051472299%29_%28cropped%29.jpg/330px-Madonna_Rebel_Heart_Tour_2015_-_Stockholm_%2823051472299%29_%28cropped%29.jpg",
                Detalle = "Detalles del artista"
            });

            //Maluma
            Cantantes.Add(new Cantante
            {
                Nombre = "Maluma",
                Genero = "Reguetón / Trap / Pop Latino",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bf/Maluma_-_Sin_contrato_-_Festival_de_Vi%C3%B1a_del_Mar_2017.jpg/300px-Maluma_-_Sin_contrato_-_Festival_de_Vi%C3%B1a_del_Mar_2017.jpg",
                Detalle = "Detalles del artista"
            });

            //Marco ANtonio Solis
            Cantantes.Add(new Cantante
            {
                Nombre = "Marco Antonio S.",
                Genero = "Pop Latino / Grupero / Mariachi / Cumbia / Bachata",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/0/05/MarcoAntonioSolisCollage-1-1000_adjusted.jpg",
                Detalle = "Detalles del artista"
            });

            //Miley Cyrus
            Cantantes.Add(new Cantante
            {
                Nombre = "Miley Cyrus",
                Genero = "Pop / Rock / Dance / Pop Rock / Country",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/52/Miley_Cyrus_Primavera19_-226_%2848986293772%29_%28cropped%29.jpg/330px-Miley_Cyrus_Primavera19_-226_%2848986293772%29_%28cropped%29.jpg",
                Detalle = "Detalles del artista"
            });

            //Naoto Raymi
            Cantantes.Add(new Cantante
            {
                Nombre = "Naoto Raymi",
                Genero = "J-Pop / Funk / Latino",
                ImagenUrl = "https://aramajapan.com/wp-content/uploads/2014/09/aramajapan_thumb-tpia-20140827-201408270004-entame.jpg",
                Detalle = "Detalles del artista"
            });

            //Nicki Minaj
            Cantantes.Add(new Cantante
            {
                Nombre = "Nicki Minaj",
                Genero = "Hip Hop / Trap Latino / R&B / Pop / Dance",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8d/Nicki_Minaj_Realize_NBA_Awards_2017.png/375px-Nicki_Minaj_Realize_NBA_Awards_2017.png",
                Detalle = "Detalles del artista"
            });

            //Pedro Fernandez
            Cantantes.Add(new Cantante
            {
                Nombre = "Pedro Fernandez",
                Genero = "Mariachi / Balada Romántica / Pop Latino / Música Tradicional / Banda",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/Pedro_Fern%C3%A1ndez_en_2014.jpg/330px-Pedro_Fern%C3%A1ndez_en_2014.jpg",
                Detalle = "Detalles del artista"
            });

            //Rauw Alejandro
            Cantantes.Add(new Cantante
            {
                Nombre = "Rauw Alejandro",
                Genero = "R&B Contemporáneo / Urban",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/53/Raw_alejandro.jpg/330px-Raw_alejandro.jpg",
                Detalle = "Detalles del artista"
            });

            //Romeo Santos
            Cantantes.Add(new Cantante
            {
                Nombre = "Romeo Santos",
                Genero = "Bachata / Merengue",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/08/Romeo_Santos_y_Juan_Luis_Guerra_%28cropped%29.jpg/330px-Romeo_Santos_y_Juan_Luis_Guerra_%28cropped%29.jpg",
                Detalle = "Detalles del artista"
            });

            //Rosalia
            Cantantes.Add(new Cantante
            {
                Nombre = "Rosalia",
                Genero = "Flamenco / R&B / Art Pop / Nuevo Flamenco / Reguetón",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Rosalia_2019-portrait.jpg/330px-Rosalia_2019-portrait.jpg",
                Detalle = "Detalles del artista"
            });

            //Shakira
            Cantantes.Add(new Cantante
            {
                Nombre = "Shakira",
                Genero = "Pop / Dance / Urban / Reguetón / Pop Rock / Trap",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1d/Shakira_for_VOGUE_in_2021_2.png/330px-Shakira_for_VOGUE_in_2021_2.png",
                Detalle = "Detalles del artista"
            });

            //Sia
            Cantantes.Add(new Cantante
            {
                Nombre = "Sia",
                Genero = "Pop / Dream Pop / Indie Pop / Electropop / Synth-pop",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/49/SIaFurler_Boston2016live.jpg/330px-SIaFurler_Boston2016live.jpg",
                Detalle = "Detalles del artista"
            });

            //Taylor Swift
            Cantantes.Add(new Cantante
            {
                Nombre = "Taylor Swift",
                Genero = "Pop / Country / Rock Alternativo / Country Pop / Folk Pop / Electropop / Synth Pop / Bubblegum Pop / Country Rock",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d9/191125_Taylor_Swift_at_the_2019_American_Music_Awards.png/330px-191125_Taylor_Swift_at_the_2019_American_Music_Awards.png",
                Detalle = "Detalles del artista"
            });

            //Victoria Justice
            Cantantes.Add(new Cantante
            {
                Nombre = "Victoria Justice",
                Genero = "Pop",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cf/Victoria_Justice_2013.jpg/330px-Victoria_Justice_2013.jpg",
                Detalle = "Detalles del artista"
            });

            BindingContext = this;
        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cantante selectedItem = e.CurrentSelection[0] as Cantante;
            //await Navigation.PushAsync(new DetallesArtista());
            //var artist = ((ListView)sender).SelectedItem as Cantante;

            if (selectedItem == null)
                return;
            await DisplayAlert("Detalles", selectedItem.Detalle, "ok");
        }
        private async void BtnRegistrar(object sender, EventArgs e)
        {
            // await Navigation.PushAsync();
            await Navigation.PushAsync(new RegistrarUsuario());
        }
    }
}
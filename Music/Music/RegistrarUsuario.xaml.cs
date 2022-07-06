using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Music.Entities;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Music
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrarUsuario : ContentPage
    {
        private List<Estado> Glb_ListEstados;
        private List<Municipio> Glb_ListMunicipios;
        private List<Colonia> Glb_ListColonias;
        private int Gbl_IdColonia;

        public RegistrarUsuario()
        {
            InitializeComponent();
            RequestApiXamarin("Estados");
        }

        private async void RequestApiXamarin(string metodo, int id = 0)
        {
            var request = new HttpRequestMessage();
            string UrlMethod = "";

            if (id == 0)
            {
                // Estados
                UrlMethod = metodo;
            }
            else
            {
                UrlMethod = metodo + "/" + id;
            }

            // http://www.desweb-profesional.somee.com/api/Estados
            // http://www.desweb-profesional.somee.com/api/Municipios/1
            request.RequestUri = new Uri("http://www.desweb-profesional.somee.com/api/" + UrlMethod);
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accept", "application/json");
            var client = new HttpClient();
            HttpResponseMessage response = await client.SendAsync(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                string content = await response.Content.ReadAsStringAsync();
                switch (metodo)
                {
                    case "Estados":
                        setEstadosPicker(JsonConvert.DeserializeObject<List<Estado>>(content));
                        break;

                    case "Municipios":
                        setMunicipiosPicker(JsonConvert.DeserializeObject<List<Municipio>>(content));
                        break;

                    case "Colonias":
                        setColoniasPicker(JsonConvert.DeserializeObject<List<Colonia>>(content));
                        break;

                    default:
                        break;
                }
            }
        } 

        private void setEstadosPicker(List<Estado> estados)
        {
            List<string> ListEstados = new List<string>();

            // Lista global de estados es igual a los estados recibidos de la API
            this.Glb_ListEstados = estados;
            foreach (var estado in estados)
            {
                ListEstados.Add(estado.nombreEstado);
            }

            pickerEstados.ItemsSource = ListEstados;
        }

        private void setMunicipiosPicker(List<Municipio> municipios)
        {
            List<string> ListMunicipios = new List<string>();
            this.Glb_ListMunicipios = municipios;
            foreach (var municipio in municipios)
            {
                ListMunicipios.Add(municipio.nombreMunicipio);
            }
            pickerMunicipios.ItemsSource = ListMunicipios;
        }

        private void setColoniasPicker(List<Colonia> colonias)
        {
            List<string> ListColonias = new List<string>();
            this.Glb_ListColonias = colonias;
            foreach (var colonia in colonias)
            {
                ListColonias.Add(colonia.nombreColonia);
            }
            pickerColonias.ItemsSource = ListColonias;
        }

        private void pickerEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickerEstados.SelectedIndex != -1)
            {
                pickerColonias.IsEnabled = false;
                pickerColonias.ItemsSource = null;

                // Obtenemos el nombre del estado que el usuario está seleccionando
                string nombreEstado = Regex.Replace(pickerEstados.SelectedItem.ToString(), @"\s", "");
                int idEstado = 0;

                // Iteramos sobre la lista global de estados
                foreach (var estado in this.Glb_ListEstados)
                {
                    // Comparamos cuando haya una concidencia entre el nombre de estado que el usuario seleccionó y 
                    // Algún valor dentro de la lista global de estados
                    if (nombreEstado == Regex.Replace(estado.nombreEstado, @"\s", ""))
                    {
                        // Se guarda el id del estado
                        idEstado = estado.isEstado;
                        break;
                        //DisplayAlert("Alert", "Estado seleccionado: " + estado.isEstado + " -- " + estado.nombreEstado, "OK");
                    }
                }

                RequestApiXamarin("Municipios", idEstado);
                pickerMunicipios.IsEnabled = true;
            }
        }

        private void pickerMunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickerMunicipios.SelectedIndex != -1)
            {
                string nombreMunicipio = Regex.Replace(pickerMunicipios.SelectedItem.ToString(), @"\s", "");
                int idMunicipio = 0;

                foreach (var municipio in this.Glb_ListMunicipios)
                {
                    if (nombreMunicipio == Regex.Replace(municipio.nombreMunicipio, @"\s", ""))
                    {
                        idMunicipio = municipio.idMunicipio;
                        break;
                    }
                }
                RequestApiXamarin("Colonias", idMunicipio);
                pickerColonias.IsEnabled = true;
            }
        }

        private void pickerColonias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickerColonias.SelectedIndex != -1)
            {
                string nombreColonia = Regex.Replace(pickerColonias.SelectedItem.ToString(), @"\s", "");

                foreach (var colonia in this.Glb_ListColonias)
                {
                    if (nombreColonia == Regex.Replace(colonia.nombreColonia, @"\s", ""))
                    {
                        this.Gbl_IdColonia = colonia.idColonia;
                        break;
                    }
                }
            }
        }

        private async void BtnRegistrar_Clicked(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario()
            {
                nombreUsuario = txt_nombrePersona.Text,
                apPaterno = txt_aPaternoPersona.Text,
                apMaterno = txt_aMaternoPersona.Text,
                telefonoUsuario = txt_telPersona.Text,
                idColonia = this.Gbl_IdColonia.ToString()
            };

            Uri RequestUri = new Uri("http://www.desweb-profesional.somee.com/api/Usuarios");

            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(usuario);
            var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(RequestUri, contentJson);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                await DisplayAlert("Datos", "Usuario agregado.", "Ok");
                txt_nombrePersona.Text = "";
                txt_aPaternoPersona.Text = "";
                txt_aMaternoPersona.Text = "";
                txt_telPersona.Text = "";

                pickerEstados.ItemsSource = null;
                pickerMunicipios.ItemsSource = null;
                pickerMunicipios.IsEnabled = false;
                pickerColonias.ItemsSource = null;
                pickerColonias.IsEnabled = false;

                RequestApiXamarin("Estados");
            }
            else
            {
                await DisplayAlert("Error", "Error al agregar, intente nuevamente.", "Cerrar");
            }
        }
    }
}
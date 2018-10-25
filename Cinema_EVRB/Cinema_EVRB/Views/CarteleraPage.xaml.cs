using Cinema_EVRB.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema_EVRB.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarteleraPage : ContentPage
	{
		public CarteleraPage ()
		{
			InitializeComponent ();
            CargarCartelera();
		}

        private async void CargarCartelera()
        {
            HttpClient cliente = new HttpClient();
            cliente.BaseAddress = new Uri("https://misapis.azurewebsites.net");

            var request = await cliente.GetAsync("/api/Cartelera");
            if (request.IsSuccessStatusCode)
            {
                var responseJson = await request.Content.ReadAsStringAsync();
                var carteleras = JsonConvert.DeserializeObject<List<CinemaModel>>(responseJson);
                listcarteleras.ItemsSource = carteleras;

            }
        }

        private async void PeliculaSeleccionada(object sender, SelectedItemChangedEventArgs e)
        {
            var funcion = e.SelectedItem as FuncionesModel;
            await Navigation.PushModalAsync(new FuncionesPage(funcion));
        }
    }
}
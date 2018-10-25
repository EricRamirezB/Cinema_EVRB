using Cinema_EVRB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinema_EVRB.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FuncionesPage : ContentPage
	{
		public FuncionesPage (FuncionesModel funcion)
		{
			InitializeComponent ();
            BindingContext = funcion;

        }
	}
}
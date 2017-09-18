using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaDesejos2.View;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaDesejos2.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : ContentPage
	{
        

        public Menu ()
		{
			InitializeComponent ();
		}
         protected async void ListarDesejos(Object listar, EventArgs sender)
        {
            await App.NavigateMaster(new ListDesejos()); 
        }
        protected async void EditarDesejo(Object editar, EventArgs sender)
        {
            await App.NavigateMaster(new EditDesejo());
        }
        protected async void DetalharDesejo(Object detalhar, EventArgs sender)
        {
            await App.NavigateMaster(new DetailDesejo());
        }
        protected async void InserirDesejo(Object inserir, EventArgs sender)
        {
            await App.NavigateMaster(new InsertDesejo());
        }

    }
}
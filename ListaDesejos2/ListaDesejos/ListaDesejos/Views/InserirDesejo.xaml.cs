using System;
using ListaDesejos;
using ListaDesejos.Models;
using ListaDesejos.ViewModel;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaDesejos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InserirDesejo : ContentPage
	{
		public InserirDesejo ()
		{
			InitializeComponent ();
            DesejoViewModel desejoViewModel = new DesejoViewModel();
            this.BindingContext = desejoViewModel;
           
        }
 
    }
}

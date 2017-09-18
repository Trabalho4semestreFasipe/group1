using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListaDesejos2.Models
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Desejo : ContentPage
	{
        public int Codigo;
        public string Produto;
        public string Categoria;
        public string Loja;
        public double PrecoMin;
        public double precoMax;

        public Desejo ()
		{
			InitializeComponent ();
		}
       
    }
}
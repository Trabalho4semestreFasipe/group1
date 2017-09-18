using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ListaDesejos2.Models;

using Xamarin.Forms;

namespace ListaDesejos2.View
{
	public class MasterDetail : MasterDetailPage
	{
		public MasterDetail ()
		{
            this.Master = new Menu();
            this.Detail = new Navigation(new Desejo());
            App.MasterDetail = this;
			
		}
	}
}
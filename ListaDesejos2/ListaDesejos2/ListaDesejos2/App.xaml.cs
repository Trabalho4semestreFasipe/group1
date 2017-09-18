using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ListaDesejos2.Models;
using ListaDesejos2.View;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace ListaDesejos2
{
	public partial class App : Application
	{
        public static MasterDetailPage MasterDetail { get; set; }
        public async static Task NavigateMaster (Page page)
        {
            App.MasterDetail.IsPresented = false;
            await App.MasterDetail.Detail.Navigation.PushAsync(page);

        }


		public App ()
		{
			InitializeComponent();

            MainPage = new MasterDetail();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

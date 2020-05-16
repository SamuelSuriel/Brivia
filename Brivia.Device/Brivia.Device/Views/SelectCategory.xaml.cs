using Brivia.Device.Services.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Brivia.Device.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SelectCategory : ContentPage
	{
		public SelectCategory ()
		{
			InitializeComponent ();
		}

        private void BtnTodas_Clicked(object sender, EventArgs e)
        {
            QuestionService.GetRandomQuestion();
            Application.Current.MainPage = new Juego();
        }

        private void BtnCiencia_Clicked(object sender, EventArgs e)
        {
            QuestionService.GetRandomQuestion("Ciencia");
        }

        private void BtnArte_Clicked(object sender, EventArgs e)
        {
            QuestionService.GetRandomQuestion("Arte");
        }

        private void BtnHistoria_Clicked(object sender, EventArgs e)
        {
            QuestionService.GetRandomQuestion("Historia");
        }

        private void BtnGeo_Clicked(object sender, EventArgs e)
        {
            QuestionService.GetRandomQuestion("Geografia");
        }
    }
}
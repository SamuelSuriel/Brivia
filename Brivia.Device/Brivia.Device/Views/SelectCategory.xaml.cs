using Brivia.Device.Models;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Brivia.Device.Services.QuestionService;

namespace Brivia.Device.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectCategory : ContentPage
    {
        public SelectCategory()
        {
            InitializeComponent();
        }

        private void Categoria_Clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            QuestionModel question = btn.Text == "Todas" ? GetRandomQuestion() : GetRandomQuestion(btn.Text);
            Application.Current.MainPage = new Juego(question);
        }
    }
}
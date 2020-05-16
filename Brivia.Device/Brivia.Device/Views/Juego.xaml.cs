using Brivia.Device.Models;
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
	public partial class Juego : ContentPage
	{
        // Clear this pls
        public Juego (QuestionModel question)
		{
			InitializeComponent ();
            Mount(question);
        }

        private void Mount(QuestionModel question)
        {
            CreateButtons(question);
            CreateTitle(question.Question);
        }

        private void CreateTitle(string question)
        {
            var label = (Label)FindByName("Title");
            label.Text = question;
        }

        private void CreateButtons(QuestionModel question)
        {
            foreach (var answer in GetAnswersFromQuestion(question))
            {
                var btn = new Button()
                {
                    Text = answer,
                };

                if (answer == question.CorrectAnswer) btn.ClassId = "correct";


                // Add handler
                btn.Clicked += CheckAnswer;

                MyButtons.Children.Add(btn);
            }
        }
        private void CheckAnswer(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn.ClassId == "correct")
            {
                DisplayAlert("Felicidades ", "¡Lo has hecho bien!", "OK");
                // Siguiente fase
            }
            else
            {
                DisplayAlert("Se acabó el juego ", " Perdiste!", "OK");
                // Fin del juego
            }
        }

        private List<string> GetAnswersFromQuestion(QuestionModel question)
        {
            List<string> answerList = question.IncorrectAnswers.Split('/').ToList();
            answerList.Add(question.CorrectAnswer);
            return answerList;
        }
    }
}
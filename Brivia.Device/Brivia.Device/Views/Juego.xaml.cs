using Brivia.Device.Helpers;
using Brivia.Device.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Brivia.Device.Services.QuestionService;

namespace Brivia.Device.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Juego : ContentPage
	{
        private string Category { get; set; }
        private int ActualRound { get; set; }
        public int Points { get; set; }
        public Juego(string category, int round = 0, int puntos = 10)
        {
            QuestionModel question = category == "Todas" ? GetRandomQuestion() : GetRandomQuestion(category);
            InitializeComponent ();
            Mount(question, round, puntos);
            this.Category = category;
            this.ActualRound = round;
            this.Points = puntos;
        }

        private void Mount(QuestionModel question, int round, int puntos)
        {
            CreateButtons(question);
            CreateTitle(question.Question);
            RenderInfos(round, puntos);
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
                var btn = CreateAnswerButton(answer, question);
            }
        }
        private async void CheckAnswer(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn.ClassId == "correct")
            {
                await DisplayAlert("Felicidades", "¡Respuesta Correcta!", "OK");
                NextLevel(++this.ActualRound, (this.Points * 2));
            }
            else
            {
                await DisplayAlert("Fin del juego", $"Perdiste!\nhiciste: {this.Points} puntos", "OK");
                GameOver();
            }
        }

        private Button CreateAnswerButton(string answer, QuestionModel question)
        {
            Button btn = new Button()
            {
                Text = answer,
                FontSize = 19,
            };

            if (answer == question.CorrectAnswer) btn.ClassId = "correct";

            // Add handler
            btn.Clicked += CheckAnswer;

            MyButtons.Children.Add(btn);

            return btn;
        }

        private List<string> GetAnswersFromQuestion(QuestionModel question)
        {
            List<string> answerList = question.IncorrectAnswers.Split('/').ToList();
            answerList.Add(question.CorrectAnswer);
            return answerList.Randomize().ToList();
        }

        private void RenderInfos(int round, int puntos)
        {
            Label roundLabel = (Label)FindByName("Round");
            Label pointsLabel = (Label)FindByName("Puntos");

            roundLabel.Text = $"Round: {round.ToString()}";
            pointsLabel.Text = $"Puntos: {puntos.ToString()}";
        }

        private void NextLevel(int round, int poins)
        {
            Application.Current.MainPage = new Juego(this.Category, round, poins);
        }

        private void GameOver()
        {
            Application.Current.MainPage = new SelectCategory();
        }
    }
}
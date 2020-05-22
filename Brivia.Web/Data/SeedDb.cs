using Brivia.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brivia.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _dataContext;

        public SeedDb(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task SeedAsync()
        {
            await _dataContext.Database.EnsureCreatedAsync();
            await CheckQuestionsAsync();
        }

        private async Task CheckQuestionsAsync()
        {
            if (_dataContext.Questions.Any())
            {
                return;
            }

            _dataContext.Questions.Add(new QuestionEntity
            {
                Question = "¿Cuánto tiempo había estado lisiado el cojo que sanaron Pedro y Juan?",
                Answer1 = "40 años",
                Answer2 = "50 años",
                Answer3 = "30 años",
                Answer4 = "20 años",
                CorrectAnswer = 1
            });
            _dataContext.Questions.Add(new QuestionEntity
            {
                Question = "¿Quién promulgó el edicto de que todo el mundo fuese empadronado?",
                Answer1 = "Augusto Cesar.",
                Answer2 = "Pilato",
                Answer3 = "Herodes",
                Answer4 = "Salomon",
                CorrectAnswer = 2
            });
            _dataContext.Questions.Add(new QuestionEntity
            {
                Question = "¿Cuál es el segundo mandamiento más importante?",
                Answer1 = "Amaras a Dios sobre todas las cosas",
                Answer2 = "No mataras",
                Answer3 = "Amaras a tu prójimo como a ti mismo",
                Answer4 = "No robaras",
                CorrectAnswer = 3
            });
            _dataContext.Questions.Add(new QuestionEntity
            {
                Question = "¿Cómo se llamó el único rey en la Biblia que usó un reloj?",
                Answer1 = "Ananias",
                Answer2 = "David",
                Answer3 = "Salomon",
                Answer4 = "Acaz",
                CorrectAnswer = 4
            });
            _dataContext.Questions.Add(new QuestionEntity
            {
                Question = "¿Cuántos años David reino Hebrón?",
                Answer1 = "12 años",
                Answer2 = "7 años",
                Answer3 = "17 años",
                Answer4 = "10 años",
                CorrectAnswer = 2
            });

            _dataContext.Categories.Add(new CategoryEntity
            {
                Description = "Falso o Verdadero"                
            });
            _dataContext.Categories.Add(new CategoryEntity
            {
                Description = "Preguntas Generales"
            });
            _dataContext.Categories.Add(new CategoryEntity
            {
                Description = "Personajes"
            });
            _dataContext.Categories.Add(new CategoryEntity
            {
                Description = "Charadas"
            });
            _dataContext.Categories.Add(new CategoryEntity
            {
                Description = "Antiguo Testamento"
            });
            _dataContext.Categories.Add(new CategoryEntity
            {
                Description = "Nuevo Testamento"
            });
            _dataContext.Categories.Add(new CategoryEntity
            {
                Description = "Apocalipsis"
            });
            await _dataContext.SaveChangesAsync();
        }
    }
}

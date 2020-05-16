using Brivia.Device.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brivia.Device.Helpers
{
    public static class Seed
    {
        // Seed Users
        public static List<UserModel> SeedUsers()
        {
            return new List<UserModel>
            {
                new UserModel("admin", "admin"),
                new UserModel("marco", "123"),
                new UserModel("heart", "password"),
                new UserModel("gmail", "777"),
                new UserModel("samuel", "1234"),
                new UserModel("java", "java")
            };
        }

        // Seed Questions
        public static List<QuestionModel> SeedQuestions()
        {
            return new List<QuestionModel>
            {
                new QuestionModel(1, "¿De quién es la famosa frase que pienso, luego existo? "," Descartes "," Arte "," Platón / Sócrates / Galileo Galilei"),
                new QuestionModel(2, "¿Cuál es el país más pequeño y más grande del mundo? "," Vaticano y Rusia "," Geografía "," Nauru y China / Mónaco y Canadá / Malta y Estados Unidos"),
                new QuestionModel(3, "¿Cómo se llama el presidente de Brasil, conocido como Jango? "," João Goulart "," Historia "," Jânio Quadros / Getúlio Vargas / João Figueiredo"),
                new QuestionModel(4, "¿Qué países tienen la esperanza de vida más alta y más baja del mundo? "," Japón y Sierra Leona "," Geografía "," Estados Unidos y Angola / Brasil y Congo / Australia y Afganistán"),
                new QuestionModel(5, "¿Cuál es el número mínimo de jugadores en un partido de fútbol? "," 7 "," Entretenimiento "," 10/08/5"),
                new QuestionModel(6, "¿Quién pintó 'Guernica'? "," Pablo Picasso "," Art "," Paul Cézanne / Diego Rivera / arsila do Amaral"),
                new QuestionModel(7, "¿Cuánto tiempo tarda la luz solar en llegar a la Tierra? "," 8 minutos "," Ciencia "," 12 horas / 1 día / 12 minutos"),
                new QuestionModel(8, "¿Cuál es la nacionalidad del Che Guevara? "," Argentina "," Historia "," Boliviana / Panamenha / Cubana"),
                new QuestionModel(9, "¿En qué período de la prehistoria se descubrió el fuego? "," Paleolítico "," Historia "," Edad Media / Neolítico / Edad de los metales"),
                new QuestionModel(10, "¿Cuál es el animal terrestre más grande? "," Elefante africano "," Ciencia "," Jirafa / Tiburón blanco / Dinosaurio"),
            };
        }
    }
}

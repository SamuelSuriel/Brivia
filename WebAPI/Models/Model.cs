using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Brivia : DbContext
    {
        public Brivia(DbContextOptions<Brivia> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameDetail> GameDetails { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public int GamesWon { get; set; }
        public int MissedGames { get; set; }
    }

    public class Question
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public Category IdCategory { get; set; }
        [Required]
        public string IncorrectAnswer1 { get; set; }
        [Required]
        public string IncorrectAnswer2 { get; set; }
        [Required]
        public string IncorrectAnswer3 { get; set; }
        [Required]
        public string IncorrectAnswer4 { get; set; }
        [Required]
        public int CorrectAnswer { get; set; }
        public User IdUser { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }

    }

    public class Record
    {
        public int Id { get; set; }
        public User IdUser { get; set; }
        public Category IdCategory { get; set; }
        public int CorrectAnswer { get; set; }
    }

    public class Game
    {
        public int Id { get; set; }
        public int IdUser1 { get; set; }
        public int IdUser2 { get; set; }
        public int Turn { get; set; }
        public DateTime Date { get; set; }
        public int Round { get; set; }
        public int CorrectAnwer1 { get; set; }
        public int Person1 { get; set; }
        public int CorrectAnwer2 { get; set; }
        public int Person2 { get; set; }
    }

    public class GameDetail
    {
        public int Id { get; set; }
        public Game IdGame { get; set; }
        public User IdUser { get; set; }
        public Category IdCategory { get; set; }
    }
}

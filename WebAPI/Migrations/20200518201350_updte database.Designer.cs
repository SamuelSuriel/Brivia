﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Models;

namespace WebAPI.Migrations
{
    [DbContext(typeof(Brivia))]
    [Migration("20200518201350_updte database")]
    partial class updtedatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WebAPI.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CorrectAnwer1");

                    b.Property<int>("CorrectAnwer2");

                    b.Property<DateTime>("Date");

                    b.Property<int>("IdUser1");

                    b.Property<int>("IdUser2");

                    b.Property<int>("Person1");

                    b.Property<int>("Person2");

                    b.Property<int>("Round");

                    b.Property<int>("Turn");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("WebAPI.Models.GameDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdCategoryId");

                    b.Property<int?>("IdGameId");

                    b.Property<int?>("IdUserId");

                    b.HasKey("Id");

                    b.HasIndex("IdCategoryId");

                    b.HasIndex("IdGameId");

                    b.HasIndex("IdUserId");

                    b.ToTable("GameDetails");
                });

            modelBuilder.Entity("WebAPI.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CorrectAnswer");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int?>("IdCategoryId");

                    b.Property<int?>("IdUserId");

                    b.Property<string>("IncorrectAnswer1")
                        .IsRequired();

                    b.Property<string>("IncorrectAnswer2")
                        .IsRequired();

                    b.Property<string>("IncorrectAnswer3")
                        .IsRequired();

                    b.Property<string>("IncorrectAnswer4")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdCategoryId");

                    b.HasIndex("IdUserId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("WebAPI.Models.Record", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CorrectAnswer");

                    b.Property<int?>("IdCategoryId");

                    b.Property<int?>("IdUserId");

                    b.HasKey("Id");

                    b.HasIndex("IdCategoryId");

                    b.HasIndex("IdUserId");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("WebAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GamesWon");

                    b.Property<string>("Lastname")
                        .IsRequired();

                    b.Property<int>("MissedGames");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebAPI.Models.GameDetail", b =>
                {
                    b.HasOne("WebAPI.Models.Category", "IdCategory")
                        .WithMany()
                        .HasForeignKey("IdCategoryId");

                    b.HasOne("WebAPI.Models.Game", "IdGame")
                        .WithMany()
                        .HasForeignKey("IdGameId");

                    b.HasOne("WebAPI.Models.User", "IdUser")
                        .WithMany()
                        .HasForeignKey("IdUserId");
                });

            modelBuilder.Entity("WebAPI.Models.Question", b =>
                {
                    b.HasOne("WebAPI.Models.Category", "IdCategory")
                        .WithMany()
                        .HasForeignKey("IdCategoryId");

                    b.HasOne("WebAPI.Models.User", "IdUser")
                        .WithMany()
                        .HasForeignKey("IdUserId");
                });

            modelBuilder.Entity("WebAPI.Models.Record", b =>
                {
                    b.HasOne("WebAPI.Models.Category", "IdCategory")
                        .WithMany()
                        .HasForeignKey("IdCategoryId");

                    b.HasOne("WebAPI.Models.User", "IdUser")
                        .WithMany()
                        .HasForeignKey("IdUserId");
                });
#pragma warning restore 612, 618
        }
    }
}

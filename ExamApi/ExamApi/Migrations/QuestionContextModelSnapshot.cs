﻿// <auto-generated />
using ExamApi.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExamApi.Migrations
{
    [DbContext(typeof(QuestionContext))]
    partial class QuestionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113");

            modelBuilder.Entity("ExamApi.Models.Question", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("answer1");

                    b.Property<string>("answer2");

                    b.Property<string>("answer3");

                    b.Property<string>("answer4");

                    b.Property<bool>("true_answer");

                    b.Property<string>("question");

                    b.HasKey("Id");

                    b.ToTable("Question");

                    b.HasData(
                        new { Id = 1L, answer1 = "Paris", answer2 = "Rome", answer3 = "London", answer4 = "Berlin", has_time = true, question = "What's the capital of France?"},
                        new { Id = 2L, answer1 = "Paris", answer2 = "Rome", answer3 = "London", answer4 = "Berlin", has_time = true, question = "What's the capital of Italy?"}
                    );
                });
#pragma warning restore 612, 618
        }
    }
}

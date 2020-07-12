﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectSchool_API.Data;

namespace ProjectSchool_API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("ProjectSchool_API.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DataNasc");

                    b.Property<string>("Nome");

                    b.Property<int>("ProfessorId");

                    b.Property<string>("Sobrenome");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataNasc = "01/05/2000",
                            Nome = "Maria",
                            ProfessorId = 1,
                            Sobrenome = "José"
                        },
                        new
                        {
                            Id = 2,
                            DataNasc = "25/06/1999",
                            Nome = "João",
                            ProfessorId = 2,
                            Sobrenome = "Paulo"
                        },
                        new
                        {
                            Id = 3,
                            DataNasc = "11/07/1980",
                            Nome = "Lucas",
                            ProfessorId = 3,
                            Sobrenome = "Machado"
                        });
                });

            modelBuilder.Entity("ProjectSchool_API.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Vinicius"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Paula"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Luna"
                        });
                });

            modelBuilder.Entity("ProjectSchool_API.Models.Aluno", b =>
                {
                    b.HasOne("ProjectSchool_API.Models.Professor", "Professor")
                        .WithMany("Alunos")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

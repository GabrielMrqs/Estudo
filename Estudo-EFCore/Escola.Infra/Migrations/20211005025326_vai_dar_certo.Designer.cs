﻿// <auto-generated />
using System;
using Escola.Infra.ORM.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Escola.Infra.Migrations
{
    [DbContext(typeof(AulaContext))]
    [Migration("20211005025326_vai_dar_certo")]
    partial class vai_dar_certo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Escola.Dominio.AlunoModule.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("SMALLDATETIME");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(80)");

                    b.Property<int>("Idade")
                        .HasColumnType("INT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(80)");

                    b.HasKey("Id");

                    b.ToTable("TBAlunos");
                });

            modelBuilder.Entity("Escola.Dominio.AulaModule.Aula", b =>
                {
                    b.Property<int>("IdAluno")
                        .HasColumnType("int");

                    b.Property<int>("IdProfessor")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAluno", "IdProfessor");

                    b.HasIndex("IdProfessor");

                    b.ToTable("TBAulas");
                });

            modelBuilder.Entity("Escola.Dominio.ProfessorModule.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("SMALLDATETIME");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(80)");

                    b.Property<int>("Idade")
                        .HasColumnType("INT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(80)");

                    b.HasKey("Id");

                    b.ToTable("TBProfessores");
                });

            modelBuilder.Entity("Escola.Dominio.AulaModule.Aula", b =>
                {
                    b.HasOne("Escola.Dominio.AlunoModule.Aluno", "Aluno")
                        .WithMany("Aulas")
                        .HasForeignKey("IdAluno")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Escola.Dominio.ProfessorModule.Professor", "Professor")
                        .WithMany("Aulas")
                        .HasForeignKey("IdProfessor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("Escola.Dominio.AlunoModule.Aluno", b =>
                {
                    b.Navigation("Aulas");
                });

            modelBuilder.Entity("Escola.Dominio.ProfessorModule.Professor", b =>
                {
                    b.Navigation("Aulas");
                });
#pragma warning restore 612, 618
        }
    }
}

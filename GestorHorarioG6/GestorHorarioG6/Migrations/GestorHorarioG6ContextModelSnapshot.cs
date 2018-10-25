﻿// <auto-generated />
using System;
using GestorHorarioG6.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestorHorarioG6.Migrations
{
    [DbContext(typeof(GestorHorarioG6Context))]
    partial class GestorHorarioG6ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GestorHorarioG6.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cargo");

                    b.Property<string>("Email");

                    b.Property<int>("NIF");

                    b.Property<DateTime>("Nascimento");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Notas");

                    b.Property<int>("Telefone");

                    b.HasKey("FuncionarioID");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("GestorHorarioG6.Models.Trocas", b =>
                {
                    b.Property<int>("TrocasID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aprovado");

                    b.Property<bool>("Conhecimento");

                    b.Property<int>("IDFuncionario1FuncionarioID");

                    b.Property<int?>("IDFuncionario2FuncionarioID");

                    b.Property<int>("Turno1");

                    b.Property<int>("Turno2");

                    b.HasKey("TrocasID");

                    b.HasIndex("IDFuncionario1FuncionarioID");

                    b.HasIndex("IDFuncionario2FuncionarioID");

                    b.ToTable("Trocas");
                });

            modelBuilder.Entity("GestorHorarioG6.Models.Trocas", b =>
                {
                    b.HasOne("GestorHorarioG6.Models.Funcionario", "IDFuncionario1")
                        .WithMany()
                        .HasForeignKey("IDFuncionario1FuncionarioID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GestorHorarioG6.Models.Funcionario", "IDFuncionario2")
                        .WithMany()
                        .HasForeignKey("IDFuncionario2FuncionarioID");
                });
#pragma warning restore 612, 618
        }
    }
}

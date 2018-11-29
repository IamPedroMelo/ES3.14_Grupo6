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
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GestorHorarioG6.Models.Cargo", b =>
                {
                    b.Property<int>("CargoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("CargoId");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("GestorHorarioG6.Models.Departamento", b =>
                {
                    b.Property<int>("DepartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("DepartamentoId");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("GestorHorarioG6.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CargoId");

                    b.Property<string>("Email");

                    b.Property<string>("NIF")
                        .IsRequired();

                    b.Property<DateTime>("Nascimento");

                    b.Property<DateTime>("NascimentoFilho");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Notas");

                    b.Property<string>("Telefone")
                        .IsRequired();

                    b.HasKey("FuncionarioId");

                    b.HasIndex("CargoId");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("GestorHorarioG6.Models.Requisicao", b =>
                {
                    b.Property<int>("RequisicaoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aprovado");

                    b.Property<int>("DepartamentoId");

                    b.Property<DateTime>("HoraDeFim");

                    b.Property<DateTime>("HoraDeInicio");

                    b.Property<string>("RequisicoesAdicionais");

                    b.HasKey("RequisicaoId");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Requisicao");
                });

            modelBuilder.Entity("GestorHorarioG6.Models.Servico", b =>
                {
                    b.Property<int>("ServicoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descrição");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("ServicoId");

                    b.ToTable("Servico");
                });

            modelBuilder.Entity("GestorHorarioG6.Models.Funcionario", b =>
                {
                    b.HasOne("GestorHorarioG6.Models.Cargo", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GestorHorarioG6.Models.Requisicao", b =>
                {
                    b.HasOne("GestorHorarioG6.Models.Departamento", "Departamento")
                        .WithMany()
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

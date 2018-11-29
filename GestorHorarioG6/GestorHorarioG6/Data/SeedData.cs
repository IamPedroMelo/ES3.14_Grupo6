﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorHorarioG6.Models
{
    public static class SeedData
    {
        public static void Populate(IServiceProvider applicationServices)
        {
            using
            (var serviceScope = applicationServices.CreateScope())
            {
                var db = serviceScope.ServiceProvider.GetService<GestorHorarioG6Context>();
                if (!db.Departamento.Any())
                {
                    db.Departamento.AddRange
                    (new Departamento { Nome = "Obstetrícia" },
                        new Departamento { Nome = "Ortopedia" },
                        new Departamento { Nome = "Pediatria" },
                        new Departamento { Nome = "Cardiologia" },
                        new Departamento { Nome = "Neurologia" }
                    );
                }

                if (!db.Requisicao.Any())
                {
                    db.Requisicao.AddRange
                    (new Requisicao { DepartamentoId = 1, HoraDeInicio = DateTime.Today, HoraDeFim = DateTime.Today, Aprovado = false },
                    new Requisicao { DepartamentoId = 2, HoraDeInicio = DateTime.Today, HoraDeFim = DateTime.Today, Aprovado = false },
                    new Requisicao { DepartamentoId = 3, HoraDeInicio = DateTime.Today, HoraDeFim = DateTime.Today, Aprovado = false },
                    new Requisicao { DepartamentoId = 4, HoraDeInicio = DateTime.Today, HoraDeFim = DateTime.Today, Aprovado = false },
                    new Requisicao { DepartamentoId = 5, HoraDeInicio = DateTime.Today, HoraDeFim = DateTime.Today, Aprovado = false }
                    );
                }

                if (!db.Servico.Any())
                {
                    db.Servico.AddRange
                    (new Servico { Nome = "Reparação", Descrição = "Reparação geral de um computador" },
                    new Servico { Nome = "Substituição" }
                    );
                }
              
                if (!db.Cargo.Any())
                {
                    db.Cargo.AddRange
                    (new Cargo { Nome = "Engenheiro Informático" },
                     new Cargo { Nome = "Engenheiro Técnico Informático" }
                    );
                }

                if (!db.Funcionario.Any())
                {
                    db.Funcionario.AddRange
                    (new Funcionario { Nome="João ",CargoId = 1, Nascimento = DateTime.Today, NascimentoFilho = DateTime.Today,NIF="256248756", Telefone="968745632", Email = "joao@gmail.com",Notas="" },
                    new Funcionario { Nome = "Emanuel ", CargoId = 2, Nascimento = DateTime.Today, NascimentoFilho = DateTime.Today, NIF = "226789478", Telefone = "925874136", Email = "emanu@hotmail.com", Notas = "" },
                    new Funcionario { Nome = "Ana ", CargoId = 2, Nascimento = DateTime.Today, NascimentoFilho = DateTime.Today, NIF = "226897456", Telefone = "965871369", Email = "ana@hotmail.com", Notas = "" },
                    new Funcionario { Nome = "Maria ", CargoId = 1, Nascimento = DateTime.Today, NascimentoFilho = DateTime.Today, NIF = "224117819", Telefone = "912789658", Email = "mari4@sapo.pt", Notas = "" },
                    new Funcionario { Nome = "António ", CargoId = 2, Nascimento = DateTime.Today, NascimentoFilho = DateTime.Today, NIF = "235587975", Telefone = "918751032", Email = "toni@gmail.com", Notas = "" },
                    new Funcionario { Nome = "Bruna ", CargoId = 2, Nascimento = DateTime.Today, NascimentoFilho = DateTime.Today, NIF = "221362789", Telefone = "917854745", Email = "bruna@outlook.com", Notas = "" }
                    );
                }
if (!db.Bloco.Any())
                {
                    db.Bloco.AddRange
                    (new Bloco { Nome = "Centro Obstrético" },
                    new Bloco { Nome = "Centro Cirúrgico" },
                    new Bloco { Nome = "UTI Pediátrica" },
                    new Bloco { Nome = "Gineco-Obstétrica" },
                    new Bloco { Nome = "Oncopediátrica" },
                    new Bloco { Nome = "Lactário" },
                    new Bloco { Nome = "Centro de Materias e Esterilização" },
                    new Bloco { Nome = "UTI Adulto" },
                    new Bloco { Nome = "UTI Neonatal" },
                    new Bloco { Nome = "Fonoaudiologia" },
                    new Bloco { Nome = "Sala de Equipamentos 1"}
                    );
                }

                if (!db.Equipamento.Any())
                {
                    db.Equipamento.AddRange
                    (new Equipamento { Nome = "Ultrasom Portátil", BlocoId = 11 },
                    new Equipamento { Nome = "Torre de vídeo endoscopia alta e baixa", BlocoId = 5 },
                    new Equipamento { Nome = "Aparelho de anestesia com monitorização", BlocoId = 2 },
                    new Equipamento { Nome = "Desfribilador", BlocoId = 11 },
                    new Equipamento { Nome = "Aparelho de Ressonância Magnética", BlocoId = 1 },
                    new Equipamento { Nome = "Aparelho de Raio X", BlocoId = 8 },
                    new Equipamento { Nome = "Hemodinâmica", BlocoId = 4 },
                    new Equipamento { Nome = "Aparelho de Hemodiálise", BlocoId = 11 }
                    );
                }
                if (!db.RequisicaoEquipamento.Any())
                {
                    db.RequisicaoEquipamento.AddRange
                    (new RequisicaoEquipamento { EquipamentoId = 1, HoraDeInicio = DateTime.Today, HoraDeFim = DateTime.Today, BlocoId = 1 },
                    new RequisicaoEquipamento { EquipamentoId = 2, HoraDeInicio = DateTime.Today, HoraDeFim = DateTime.Today, BlocoId = 2 },
                    new RequisicaoEquipamento { EquipamentoId = 3, HoraDeInicio = DateTime.Today, HoraDeFim = DateTime.Today, BlocoId = 3 },
                    new RequisicaoEquipamento { EquipamentoId = 4, HoraDeInicio = DateTime.Today, HoraDeFim = DateTime.Today, BlocoId = 4 },
                    new RequisicaoEquipamento { EquipamentoId = 5, HoraDeInicio = DateTime.Today, HoraDeFim = DateTime.Today, BlocoId = 5 },
                    new RequisicaoEquipamento { EquipamentoId = 6, HoraDeInicio = DateTime.Today, HoraDeFim = DateTime.Today, BlocoId = 6 }
                    );
                }
                db.SaveChanges();
            }
        }
    }
}
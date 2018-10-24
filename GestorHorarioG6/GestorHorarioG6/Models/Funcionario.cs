﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestorHorarioG6.Models
{
    public class Funcionario
    {
        public int FuncionarioID { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Cargo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        [Required]
        public int NIF { get; set; }
        
        public int Telefone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        public string Notas { get; set; }
    }
}

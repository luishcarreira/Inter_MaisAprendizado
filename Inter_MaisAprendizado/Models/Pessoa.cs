using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inter_MaisAprendizado.Models
{
    abstract class Pessoa
    {
        public int IdPessoa { get; set; }

        [Display(Name = "Nome")]
        [MinLength(3)]
        public string Nome { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Data Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNasc { get; set; }

        public Pessoa()
        {
            IdPessoa = 0;
            Nome = null;
            Email = null;
            DataNasc = DateTime.Now;
        }
    }
}

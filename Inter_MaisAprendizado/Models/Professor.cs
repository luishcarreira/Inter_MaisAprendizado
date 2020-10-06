using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inter_MaisAprendizado.Models
{
    public class Professor : Pessoa
    {
        [Display(Name = "Crédito")]
        [DataType(DataType.Currency)]
        public decimal Credito { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Faculdade_Gestao.Models
{
    public class Notas
    {
        public int idNotashash { get; set; }
	[Required]
	[Maxlength(70)]
        public string valorDaNotaPorDisciplina { get; set; }
    }
}
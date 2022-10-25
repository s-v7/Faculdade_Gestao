using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Faculdade_Gestao.Models
{
    public class Disciplinas
    { 
        public int idDisciplinaHash { get; set; }
	[Required]
	[Maxlength(70)]
        public string nomeDisciplina { get; set; }


    }
}
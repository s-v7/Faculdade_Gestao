using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
//using System.Text.Json.Serialization;

namespace Faculdade_Gestao.Models
{
    public class Professor
    {
        public int idProfessorHas { get; set; }
	[Required]
	[Maxlength(70)]
        public string nomeProfessor { get; set; }
	[Required]
	[Maxlength(70)]
        public string dataDeNascimento { get; set; }
	[Required]
	[Maxlength(10)]
        public int salarioProfessor { get; set; }


    }
}
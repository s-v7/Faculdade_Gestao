using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

/*
Estas são as especificações:
Criar um sistema de gestão de faculdades que deve ser capaz de manter o cadastro de cursos,
disciplinas, professores e alunos de uma Universidade. Cada curso universitário deve ter várias
disciplinas, que por sua vez, contêm um professor e muitos alunos. Além disso, o sistema deve
armazenar o nome, data de nascimento e salário dos professores. Para os alunos deve-se guardar o
nome, data de nascimento, número de matrícula e a nota dos alunos nas disciplinas matriculadas.
Requisitos:
Crie um CRUD das entidades (Cursos, Disciplinas, Professor, Aluno, Notas)
Liste os cursos e mostre o número de professores, alunos e média de suas notas para cada curso
Liste as disciplinas e mostre as informações do professor, número de alunos e suas notas para cada
disciplina
Liste os alunos e suas respectivas notas por disciplina
*/

namespace Faculdade_Gestao.Models
{
    public class Cursos
    {
        public int idCursoHash { get; set; }
	    [Required]
	    [MaxLength(70)]
        public string nomeCurso { get; set; }
	    [Required]
	    [MaxLength(70)]
        public string materias { get; set; }
	    [Required]
	    [MaxLength(50)]
        public string departamento { get; set; }

        public virtual void MetodoAImplemtear() { }
        public virtual void ListCursosTransactions() { }


    }

}
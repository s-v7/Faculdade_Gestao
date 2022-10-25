using Faculdade_Gestao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*Liste os cursos e mostre o número de professores, alunos e média de suas notas para cada curso
Liste as disciplinas e mostre as informações do professor, número de alunos e suas notas para cada
disciplina
Liste os alunos e suas respectivas notas por disciplina**/

namespace Faculdade_Gestao.Services
{
    public class Faculdade_GestaoServices
    {
	private readonly Faculdade_GestaoContext _contextFaculddadesGestao;        
	static int nextId = 3;

        public List<Cursos> Cursos { get; }
        public List<Disciplinas> disciplinas { get; }
        public List<Aluno> alunos { get; }
        static Faculdade_GestaoServices()
        {
            new Cursos { idCursoHash = 7, nomeCurso = "Engenharia de Software", departamento = "Matemática e Tecnologia da Informação" };
        }

    public static List<Cursos> GetAll() => Cursos;

    public static Cursos? Get(int id)
    {
        return Cursos.FirstOrDefault(p => p.id = Cursos.ReferenceEquals.id);
    }

    public static void Add(Cursos curso)
    {
        curso.idCursoHash = nextId++;
        Cursos.Add(curso);
    }

    public static void Delete(int id)
    {
        var curso = Get(id);
        if (curso is null)
            return;
        Cursos.Remove(curso);
    }

    public static void Update(Cursos curso)
    {
        var index = Cursos.FindIndex(p => p.id == curso.idCursoHash);
        if (index == -1)
            return;

        Cursos[index] = curso;
    }
  }
}
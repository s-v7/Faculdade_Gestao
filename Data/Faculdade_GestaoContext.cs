using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using Faculdade_Gestao.Models;

namespace Faculdade_Gestao.Data
{
    public class Faculdade_GestaoContext : DbContext
    {
        public Faculdade_GestaoContext(DbContextOptions<Faculdade_GestaoContext> svc) : base(svc)
        {

        }
        // tabelas a serem criadas no banco de dados
        public DbSet<Aluno> Alunos => Set<Aluno>();
        public DbSet<Cursos> Cursos => Set<Cursos>();
        public DbSet<Disciplinas> Disciplinas => Set<Disciplinas>();
        public DbSet<Notas> Notas => Set<Notas>();
        public DbSet<Professor> Professor => Set<Professor>()

    }
}

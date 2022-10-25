var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddSqlServer<Faculdade_GestaoContext>("Data Source=Faculdade_Gestao.db");

app.UseRouting();

//Routes Raiz 
app.MapGet("/GestaoFaculdades", () => "Rota Raiz");

//Routes Cursos
app.MapGet("/listCursos", () => "List Todas os Cursos");

app.MapGet("/listCursos/{id}", () => "List Curso por Tipo");

app.MapPost("/listCursos", () => "Create new Curso");

app.MapPut("/listCursos/{id}", () => "Atualiza por Curso");

app.MapDelete("/listCursos/{id}", () => "Delete por Curso");

//Routes Disciplinas
app.MapGet("/listDisciplinas", () => "List Disciplinas");


//Routes Alunos
app.MapGet("/listAlunos", () => "List Alunos");


app.Run();

//Author => Silas Vasconcelos
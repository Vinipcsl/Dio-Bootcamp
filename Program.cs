using C__.Net.model;

Pessoa p1 = new Pessoa("Vinicius","PEREIRA");

Pessoa p2 = new Pessoa(nome:"Vito", sobrenome:"Fernandes");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarAlunos();

cursoDeIngles.RemoverAluno(p1);
cursoDeIngles.ListarAlunos();





/*
Pessoa p1 = new Pessoa();

p1.Idade = 25;

p1.Sobrenome = "Pereira";

p1.Nome = "Vinicius";

p1.Apresentar();
*/
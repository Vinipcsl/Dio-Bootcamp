using C__.Net.model;

(int, string, string) tupla = (1, "Vinicius", "Pereira");

Console.WriteLine($"Id: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");













/*
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("GO","Goiania");
estados.Add("DF","Distrito Federal");
estados.Add("MG","Minas Gerais");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("-----------------------");
estados.Remove("DF");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}




















/*
Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);


foreach(int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento do topo {pilha.Pop()}");

foreach(int item in pilha)
{
    Console.WriteLine(item);
}









/*
Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");


foreach(int item in fila)
{
    Console.WriteLine(item);
}








//new ExemploExcecao().Metodo1();













/*
try{
string[] linhas = File.ReadAllLines("Arquivo/arquivo_Leitura.txt");


foreach(string linha in linhas)
{
    Console.WriteLine(linha);
}

} catch(Exception ex){
    Console.WriteLine($"Se lascous. {ex.Message}");
}
 finally
 {
    Console.WriteLine("Chegou aqui jovi");
 }














/*

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
using ExemploExplorando.model;
using Newtonsoft.Json;

int numero = 20;
bool par = false;
// IF ternario

par = numero.EhPar();

string mensagem = "O numero " +numero + " é " + (par ? "par" : "impar");
Console.WriteLine(mensagem);




























/*
MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AdicionarElementoArray(30);
Console.WriteLine(arrayInteiro[0]);

MeuArray<string> arrayString = new MeuArray<string>();

arrayString.AdicionarElementoArray("Teste");
Console.WriteLine(arrayString[0]);


























/*
dynamic variavelDinamica = 4;

Console.WriteLine($"Tipo da variável : {variavelDinamica.GetType()}, Valor; {variavelDinamica}");

variavelDinamica = "Texto";
Console.WriteLine($"Tipo da variável : {variavelDinamica.GetType()}, Valor; {variavelDinamica}");

variavelDinamica = true;
Console.WriteLine($"Tipo da variável : {variavelDinamica.GetType()}, Valor; {variavelDinamica}");





















/*
string conteudoArquivo = File.ReadAllText("Arquivos/ vendas.json");

List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

var listaAnonimo = listaVendas.Select(x => new {x.Produto, x.Preco});

foreach(var venda in listaAnonimo)
{
    Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco} ");
}




























/*
var tipoAnonimo = new { Nome = "Vini", Sobrenome= "Pereira", Altura = 1.65};

Console.WriteLine("Nome: " + tipoAnonimo.Nome);
Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
Console.WriteLine("Altura: " + tipoAnonimo.Altura);




















/*
string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVendas)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}" +
                     $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" +
                     $" {(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")}");

}















/*
bool? desejaReceberEmail = true;

if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)
{
    Console.WriteLine("O usuário optou por receber e-mail.");
    
}
else
{
    Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail.");
}




























/*
string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVendas)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}" +
                     $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}





















/*
DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1,"Mouse", 30.00M, dataAtual);
Venda v2 = new Venda(2,"Teclado", 40.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);
    
























/*
int numero = 20;

bool ehPar = false;

//if ternario

ehPar = numero % 2 ==0;

Console.WriteLine($"Numero {numero} é " + (ehPar ? "par" : "impar"));







/*
if (numero %2 ==0)
{
    Console.WriteLine($"Numero {numero} par");
}
else
{
    Console.WriteLine($"Numero {numero} impar");
}


























/*

Pessoa p1 = new Pessoa("Vinicius", "Pereira");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");





















/*
LeituraArquivo arquivo = new LeituraArquivo();

var (Sucesso, linhasArquivo, QtLinhas) = arquivo.LerArquivo("Arquivos/aquivoLeitura.txt");


if(Sucesso)
{
      //Console.WriteLine("Quantidade linhas do arquivo: " + QtLinhas);
    
    foreach(string linha in linhasArquivo)
    {
     Console.WriteLine(linha);
    }
    
    

    }
    else{
        Console.WriteLine("Não foi possivel ler o arquivo");
    }












/*
(int, string, string) tupla = (1, "Vinicius", "Pereira");


//ValueTuple<int, string, string> outroExemploTUpla = (1,"Vinicius","Pereira");
//var outroExemploTUplaCreate = Tuple.Create(1,"Vinicius","Pereira");


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
using ExemploExplorando.Models;
// using Models;
using Newtonsoft.Json;


string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto},  Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")} ");
}

























// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);























// LeituraArquivo arquivo = new LeituraArquivo();

// var(Sucesso, linhasArquivo, QuantidadeDeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if(Sucesso)
// {
//         Console.WriteLine("Quantidade linhas do arquivo: " + QuantidadeDeLinhas);
//         foreach(string linha in linhasArquivo)
//          {
//             Console.WriteLine(linha);
//          }
        
// }
// else
//     {
//         System.Console.WriteLine("Não foi possível ler o arquivo");
//     }




















// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP","São Paulo");
// estados.Add("BA","Bahia");
// estados.Add("MG","Minas Gerais");

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }























// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);


// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }


























// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);


// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }


// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");



// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }





















//new ExemploExcecao().Metodo1();


// using ExemploExplorando.Models;
// using System.Globalization;




// string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

// foreach(string linha in linhas)
// {
//     Console.WriteLine(linha);
// }






// Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");
// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();
 
// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();




























// Pessoa p1 = new Pessoa();
// p1.Nome = "Leonardo";
// p1.Sobrenome = "Buta";
// p1.Idade = 20;
// p1.Apresentar(); 


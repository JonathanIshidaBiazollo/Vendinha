//using Vendinha.Models;
//using Vendinha.Services;

//var servico = new ClienteService();

//var clientes = servico.Consultar();

//foreach(var cliente in clientes) {
//    Console.WriteLine(
//        $"Nome: {cliente.Nome} \n" +
//        $"CPF: {cliente.Cpf} \n" +
//        $"Email: {cliente.Email} \n" +
//        $"DataNascimento: {cliente.DataNascimento} \n" +
//        $"Idade: {cliente.Idade} \n" +
//        $"Id: {cliente.Id}" +
//        $"\n---------------------------------------");
//}

//var cliente2 = new Cliente {
//    Nome = "A",
//    Cpf = "33333333333",
//    DataNascimento = new DateTime(2000, 5, 10),
//    Email = "prompt@email.com"
//};

//bool cadastrado = servico.Criar(cliente2, out var erros);

//if (cadastrado) {
//    Console.WriteLine("Cliente Cadastrado com sucesso");
//} else {
//    foreach(var erro in erros) {
//        Console.WriteLine(erro.ErrorMessage);
//    }
//}

using Vendinha.Services;

var servico = new ClienteService();

Console.Write("Digite o nome para pesquisar: ");
string pesquisa = Console.ReadLine() ?? "";

var clientes = servico.Consultar(pesquisa);

foreach (var cliente in clientes) {
    Console.WriteLine($"{cliente.Id} - {cliente.Nome}");
}
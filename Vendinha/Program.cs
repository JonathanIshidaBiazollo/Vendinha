using Vendinha.Services;

var servico = new ClienteService();

var clientes = servico.Consultar();

foreach(var cliente in clientes) {
    Console.WriteLine(
        $"Nome: {cliente.Nome} \n" +
        $"CPF: {cliente.Cpf} \n" +
        $"Email: {cliente.Email} \n" +
        $"DataNascimento: {cliente.DataNascimento} \n" +
        $"Idade: {cliente.Idade} \n" +
        $"Id: {cliente.Id}" +
        $"\n---------------------------------------");
}
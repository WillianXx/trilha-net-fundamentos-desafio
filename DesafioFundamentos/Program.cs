// Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());   

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string escolha = string.Empty;
bool exibirMenuE = true;

// Realiza o loop do menu
while (exibirMenuE)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção: \n" +
    "1 - Cadastrar veiculo\n" +
    "2 - Remover veículo\n" +
    "3 - Listar veículos\n" +
    "4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;
        case "2":
            es.RemoverVeiculo();
            break;
        case "3":
            es.ListarVeiculos();
            break;
        case "4":
            exibirMenuE = false;
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
    
}
Console.WriteLine("O programa se encerrou");



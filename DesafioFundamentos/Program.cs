using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("\n\tBem Vindo ao Sistema de Estacionamento!");

System.Console.Write("\nInforme o preço inicial: R$");                  
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.Write("Informe o preço por hora: R$");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.WriteLine("\nDigite a sua opção:\n");
    Console.WriteLine("\t1 - Cadastrar veículo");
    Console.WriteLine("\t2 - Remover veículo");
    Console.WriteLine("\t3 - Listar veículos");
    Console.WriteLine("\t4 - Encerrar\n");

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
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("\n\tOpção inválida\n");
            break;
    }
}

Console.WriteLine("\n\tPrograma encerrado com sucesso");

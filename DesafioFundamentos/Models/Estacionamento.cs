namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            if(precoInicial <= 0 || precoPorHora <= 0) 
                throw new ArgumentException("\n\tAjuste os valores informados para o funcionamento do Estacionamento!\n");
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Clear();
            Console.Write("\nDigite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"\n\tVeículo de placa {placa} adicionado ao estacionameto.");
            Console.ResetColor();
        }

        public void RemoverVeiculo()
        {
            Console.Clear();
            Console.Write("\nDigite a placa do veículo para remover: ");
            string placa = Console.ReadLine()!;

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                System.Console.Write($"\n\tQuantas horas o veículo {placa} ficou estacionado? ");
                var input = decimal.TryParse(Console.ReadLine()!, out decimal horas);
                
                if(!input)
                    System.Console.WriteLine($"\n\tValor inválido! Tente novamente...\n");
                else
                {
                    var valorTotal = Math.Round(precoInicial + (precoPorHora * horas), 2);
                    veiculos.Remove(placa);
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine($"\nVeículo de Placa {placa} saiu do Estacionamento.\nValor cobrado = R${valorTotal}");
                    Console.ResetColor();
                } 
            }
            else
            {
                Console.WriteLine($"\nDesculpe, esse veículo de placa {placa} não está estacionado aqui. \n\tConfira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            Console.Clear();
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("\nOs veículos estacionados são:");
                veiculos.ForEach(x => System.Console.WriteLine($"\t• {x}"));
            }
            else
            {
                Console.WriteLine("\nNão há veículos estacionados até o momento.");
            }
        }
    }
}

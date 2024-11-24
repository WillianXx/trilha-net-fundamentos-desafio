using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para estacionar:");
            veiculos.Add(Console.ReadLine());
        }
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para remover:");

            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo permaneceu estacionado.");
                int horas = Convert.ToInt32(Console.ReadLine());

                decimal valorTotal = precoInicial + (precoPorHora * horas);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");

                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }
        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veiculos estacionado são:");
                foreach (var item in veiculos)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não há veiculos estacionados.");
            }
        }
    }

}
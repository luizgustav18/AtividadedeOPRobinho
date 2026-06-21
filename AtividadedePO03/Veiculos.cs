using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadedePO03
{
    public abstract class Veiculos
    {
        public string Modelo { get; set; }

        public int Ano { get; set; }

        public double ValorBaseMan { get; set;}

        public string resposta { get; set; }

        public void ReceberDados()
        {
            Console.WriteLine("Digite o modelo do veículo: ");
            Modelo = Console.ReadLine();
            Console.WriteLine("Digite o ano do veículo: ");
            Ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor base de manutenção do veículo: R$");
            ValorBaseMan = double.Parse(Console.ReadLine());
        }

        public static Veiculos EscolherVeiculo()
        {
            Console.WriteLine("Qual seu veiculo: ");
            Console.WriteLine("1 - Carro");
            Console.WriteLine("2 - Moto");
            Console.WriteLine("3 - Caminhão");
            Console.Write("Opção: ");

            string opcao = Console.ReadLine();

            if (opcao == "1" || opcao.Trim().ToLower() == "carro")
            {
                return new Carro();
            }
            else if (opcao == "2" || opcao.Trim().ToLower() == "moto")
            {
                return new Motos();
            }
            else if (opcao == "3" || opcao.Trim().ToLower() == "caminhão")
            {
                return new Caminhão();
            }
            else
            {
                Console.WriteLine("Opção inválida.");
                return null;
            }
        }

        public abstract void CalcularManutencao();

           public void MostrarDados()
            {
                Console.WriteLine($"O veículo {Modelo} do ano {Ano} tem um valor base de manutenção de R${ValorBaseMan}.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadedePO02
{
    public abstract class Pagamentos
    {
        public string Nome { get; set; }

        public string Resposta { get; set; }

        public double Valor { get; set; }


            public void ReceberDados()
            {
                Console.WriteLine("Digite o nome: ");
                Nome = Console.ReadLine();
                Console.Write("Digite o valor do pagamento: R$");
                Valor = double.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        public static Pagamentos EscolherPagamento()
        {
            Console.WriteLine("Escolha a forma de pagamento:");
            Console.WriteLine("1 - Pix");
            Console.WriteLine("2 - Crédito");
            Console.Write("Opção: ");

            string opcao = Console.ReadLine();

            if (opcao == "1" || opcao.Trim().ToLower() == "pix")
            {
                return new PagamentoPix();
            }
            else if (opcao == "2" || opcao.Trim().ToLower() == "credito")
            {
                return new PagamentoCartaoCredito();
            }
            else
            {
                Console.WriteLine("Opção inválida.");
                return null;
            }
        }
        public abstract void MetododePagamento();

        public void ProcessarPagamento()
        {
            Console.WriteLine($"Processando pagamento de R${Valor} para {Nome}...");
        }
        public void mostrarDados()
        {
            Console.WriteLine($"O pagamento de R${Valor} para {Nome} foi processado com sucesso!");
        }
    }
}

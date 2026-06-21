using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadedePO02
{
    internal class PagamentoCartaoCredito : Pagamentos
    {
        public string NumeroCartao { get; set; }

        public int Parcelas { get; set; }

        public double ValorTotal { get; set; }

        public override void MetododePagamento()
        {
            Console.WriteLine("Digite o número do cartão: ");
            NumeroCartao = Console.ReadLine();
            Console.WriteLine("Digite o número de parcelas: ");
            Parcelas = int.Parse(Console.ReadLine());

            ValorTotal = Valor / Parcelas;

            Console.WriteLine($"Realizando pagamento com cartão de crédito para {Nome} usando o cartão {NumeroCartao} no valor de {Parcelas} de R${ValorTotal}...");
        }
    }
}

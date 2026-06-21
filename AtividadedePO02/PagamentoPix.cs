using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadedePO02
{
    internal class PagamentoPix : Pagamentos
    {
        public string ChavePix { get; set; }
        public override void MetododePagamento()
        {
            Console.WriteLine("Digite a chave Pix: ");
            ChavePix = Console.ReadLine();
            Console.WriteLine($"Realizando pagamento via Pix para {Nome} com a chave {ChavePix} no valor de R${Valor}...");
        }
    }
}

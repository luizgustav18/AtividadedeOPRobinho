using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadedePO03
{
    internal class Carro : Veiculos
    {
        public int qtdPortas { get; set; } 

        public override void CalcularManutencao()
        {
            Console.WriteLine("Digite a quantidade de portas do carro: ");
            qtdPortas = int.Parse(Console.ReadLine());

            ValorBaseMan = ValorBaseMan + 200;
        }

    }
}

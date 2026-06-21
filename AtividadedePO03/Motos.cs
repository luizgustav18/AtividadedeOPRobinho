using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadedePO03
{
    internal class Motos : Veiculos
    { 
        public int cilindradas { get; set; }

        public override void CalcularManutencao()
        {
            Console.WriteLine("Digite a cilindrada da moto: ");
            cilindradas = int.Parse(Console.ReadLine());

            ValorBaseMan = ValorBaseMan + 100;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadedePO03
{
    internal class Caminhão : Veiculos
    {
        public double CargaMaxima { get; set; }
        public override void CalcularManutencao()
        {
            Console.WriteLine("Digite a carga máxima do caminhão (em toneladas): ");
            CargaMaxima = double.Parse(Console.ReadLine());

            ValorBaseMan = ValorBaseMan + 500;
        }
    
    }
}

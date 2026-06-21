using System;

namespace AtividadedePO
{
    internal class FuncionarioCLT : Funcionario
    {
        public double Bonus { get; set; }

        public override void CalcularSalario()
        {
            SalarioTotal = SalarioBase + Bonus;
        }

        public void ReceberDadosCLT()
        {
            Console.Write("Digite o bônus: ");
            Bonus = double.Parse(Console.ReadLine());
        }

    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadedePO
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }

        public string Cargo { get; set; }

        public double SalarioBase { get; set; }

        public double SalarioTotal { get; set; }


        public void ReceberDados()
        {
            Console.WriteLine("Digite seu Nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite seu Cargo: ");
            Cargo = Console.ReadLine();
            Console.WriteLine("Digite seu Salario Base: ");
            SalarioBase = double.Parse(Console.ReadLine());
        }
        public void MostrarDados()
        {
            Console.Write($"O {Nome} tem o salário {SalarioTotal}");

        }
        public abstract void CalcularSalario();
    }
}

using System;
using AtividadedePO08;

class Program
{
    static void Main(string[] args)
    {
        decimal valorCompra = 100.00m;

        IDescontos clienteComum = new DescontoClienteComum();
        IDescontos clienteVip = new DescontoClienteVip();

        decimal valorFinalComum = clienteComum.Calcular(valorCompra);
        decimal valorFinalVip = clienteVip.Calcular(valorCompra);

        Console.WriteLine("=== CÁLCULO DE DESCONTOS ===");
        Console.WriteLine($"Valor original: R$ {valorCompra:F2}");
        Console.WriteLine();

        Console.WriteLine("Cliente Comum (5% de desconto)");
        Console.WriteLine($"Valor final: R$ {valorFinalComum:F2}");
        Console.WriteLine();

        Console.WriteLine("Cliente VIP (10% de desconto)");
        Console.WriteLine($"Valor final: R$ {valorFinalVip:F2}");
    }
}
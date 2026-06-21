using AtividadePO05;
using System;

class Program
{
    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.Clear();

            Console.WriteLine("===== CADASTRO DE PRODUTOS =====");
            Console.WriteLine("1 - Registrar Produto");
            Console.WriteLine("2 - Exibir Todos os Produtos");
            Console.WriteLine("3 - Ordenar por Preço Total");
            Console.WriteLine("0 - Sair");

            Console.Write("\nEscolha: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida!");
                Console.ReadKey();
                continue;
            }

            Console.Clear();

            switch (opcao)
            {
                case 1:
                    Sistema.CadastrarProduto();

                    Console.WriteLine("\nProduto registrado com sucesso!");
                    break;


                case 2:

                    Sistema.ListarProdutos();

                    break;

                case 3:

                    double somaTotal = 0;

                    foreach (var produto in Sistema.produtos)
                    {
                        somaTotal += produto.Preco;
                    }

                    Console.WriteLine($"Soma total dos preços: R$ {somaTotal:F2}");

                    break;


                case 0:

                    Console.WriteLine("Encerrando o sistema...");

                    break;

                default:

                    Console.WriteLine("Opção inválida!");

                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcao != 0);
    }
}
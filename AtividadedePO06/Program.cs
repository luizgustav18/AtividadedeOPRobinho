using AtividadedePO06;
using System;

class Program
{
    static void Main(string[] args)
    {
        int opcao;

        var sistema = new Sistema();

        do
        {
            Console.Clear();

            Console.WriteLine("===== CADASTRO DE CLIENTES =====");
            Console.WriteLine("1 - Cadastrar Clientes");
            Console.WriteLine("2 - Listar Clientes");
            Console.WriteLine("3 - Buscar Clientes");
            Console.WriteLine("4 - Remover Clientes");
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
                    sistema.CadastrarCliente();

                    Console.WriteLine("\nCliente cadastrado com sucesso!");
                    break;


                case 2:

                    sistema.ListarClientes();

                    break;

                case 3:
                    sistema.BuscarClientes();

                    break;

                case 4:
                    sistema.RemoverCliente();
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
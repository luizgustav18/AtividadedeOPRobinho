using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AtividadePO05
{
    public class Sistema
    {
        public static List<Produto> produtos = new List<Produto>();

        public static void CadastrarProduto()
        {
            Produto produto = new Produto();

            Console.Write("Digite o nome do produto: ");
            produto.Nome = Console.ReadLine();
            if (produto.Nome.Length < 0)
            {
                Console.WriteLine("O nome do produto deve ser preenchido.");
                return;
            }

            Console.Write("Digite o preço do produto: ");
            produto.Preco = double.Parse(Console.ReadLine());

            produtos.Add(produto);

            Console.WriteLine("Produto cadastrado com sucesso!");
        }

        public static void ListarProdutos()
        {
            if (produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }

            Console.WriteLine("\nProdutos cadastrados:");

            foreach (Produto produto in produtos)
            {
                Console.WriteLine($"Nome: {produto.Nome} - Preço: R$ {produto.Preco:F2}");
            }
        }
    }
}
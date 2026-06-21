using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AtividadedePO06
{
    public class Sistema
    {
        public List<Cliente> clientes = new List<Cliente>();
        public void CadastrarCliente()
        {
            Cliente cliente = new Cliente();
            Console.Write("Digite o nome do cliente: ");
            cliente.Nome = Console.ReadLine();
            Console.Write("Digite o telefone do cliente: ");
            cliente.Telefone = Console.ReadLine();
            Console.Write("Digite a cidade do cliente: ");
            cliente.Cidade = Console.ReadLine();
            clientes.Add(cliente);
            Console.WriteLine("Cliente cadastrado com sucesso!");
        }
        public void ListarClientes()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
                return;
            }
            Console.WriteLine("\nClientes cadastrados:");
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine($"Nome: {cliente.Nome} - Telefone: {cliente.Telefone} - Cidade: {cliente.Cidade}");
            }
        }
        public void BuscarClientes()
        {
            Console.Write("Digite o nome do Cliente: ");
            string nomeBusca = Console.ReadLine();
            List<Cliente> clientesEncontrados = new List<Cliente>();
            foreach (var item in clientes)
            {
                if (item.Nome.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase))
                {
                    clientesEncontrados.Add(item);
                }
            }

            if (clientesEncontrados.Count > 0)
            {
                Console.WriteLine("Clientes encontrados:");
                foreach (var c in clientesEncontrados)
                {
                    Console.WriteLine($"Nome: {c.Nome} - Telefone: {c.Telefone} - Cidade: {c.Cidade}");
                }
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }
        public void RemoverCliente()
        {
            Console.Write("Digite o nome do Cliente: ");
            string nomeBusca = Console.ReadLine();
            Cliente clienteRemover = null;
            foreach (var item in clientes)
            {
                if (item.Nome.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase))
                {
                    clienteRemover = item;
                    break;
                }
            }
            if (clienteRemover != null)
            {
                clientes.Remove(clienteRemover);
                Console.WriteLine("Cliente removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }
    }
}
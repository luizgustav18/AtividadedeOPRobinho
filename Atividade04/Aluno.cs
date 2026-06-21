using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadedePO04
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string RA { get; set; }
        public int Idade { get; set; }

        public static List<Aluno> alunos = new List<Aluno>();

        public static Aluno Escolha()
        {
            int opcao;
            Console.Clear();

            Console.WriteLine("Escolha a opção: ");
            Console.WriteLine("1 - Cadastrar Aluno ");
            Console.WriteLine("2 - Listar todos os alunos cadastrados ");
            Console.WriteLine("3 - Alterar dados de Alunos ");
            Console.WriteLine("4 - Remover Aluno ");
            Console.WriteLine("5 - Encerrar programa ");
            Console.Write("Opção: ");

            opcao = int.Parse(Console.ReadLine());
            Console.Clear();

            switch(opcao)
           {
               case 1:
                   return CadastrarAluno();
               case 2:
                   ListarAlunos();
                   return null;
               case 3:
                   AlterarAluno();
                   return null;
               case 4:
                   RemoverAluno();
                   return null;
               case 5:
                   Console.WriteLine("Encerrando programa...");
                   Environment.Exit(0);
                   return null;
               default:
                   Console.WriteLine("Opção inválida. Tente novamente.");
                   return Escolha();
           }
            if (opcao != 0)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            while (opcao != 0) ;
        }

        public static Aluno CadastrarAluno()
        {
            Aluno aluno = new Aluno();
            Console.Write("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Digite o RA do aluno: ");
            aluno.RA = Console.ReadLine();

            foreach (var existente in alunos)
            {
                if (existente.RA == aluno.RA)
                {
                    Console.WriteLine("RA já cadastrado!");
                    return null;
                }
            }

            Console.Write("Digite a idade do aluno: ");
            if (!int.TryParse(Console.ReadLine(), out int idade))
            {
                Console.WriteLine("Idade inválida.");
                return null;
            }
            aluno.Idade = idade;

            alunos.Add(aluno);
            Console.WriteLine("Aluno cadastrado com sucesso!");
            return aluno;
        }

        public static void ListarAlunos()
        {
            Console.WriteLine("Alunos cadastrados: ");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}, RA: {aluno.RA}, Idade: {aluno.Idade}");
            }
        }

        public static void AlterarAluno()
        {
            Console.Write("Digite o RA do aluno que deseja alterar: ");
            string ra = Console.ReadLine();
            Aluno aluno = alunos.Find(a => a.RA == ra);
            if (aluno != null)
            {
                Console.Write("Digite o novo nome do aluno: ");
                aluno.Nome = Console.ReadLine();
                Console.Write("Digite a nova idade do aluno: ");
                aluno.Idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Aluno alterado com sucesso!");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado.");
            }
        }

        public static void RemoverAluno()
        {
            Console.Write("Digite o RA do aluno que deseja remover: ");
            string ra = Console.ReadLine();
            Aluno aluno = alunos.Find(a => a.RA == ra);
            if (aluno != null)
            {
                alunos.Remove(aluno);
                Console.WriteLine("Aluno removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado.");
            }
        }
    }
}
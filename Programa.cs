using System;
using System.Collections.Generic;

namespace GerenciadorTarefas
{
    class Programa
    {
        static void Main(string[] args)
        {
            var servicoTarefas = new ServicoTarefas();
            var tarefas = servicoTarefas.CarregarTarefas();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Gerenciador de Tarefas");
                Console.WriteLine("1. Adicionar tarefa");
                Console.WriteLine("2. Listar tarefas");
                Console.WriteLine("3. Remover tarefa");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");

                var escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        AdicionarTarefa(tarefas);
                        break;
                    case "2":
                        ListarTarefas(tarefas);
                        break;
                    case "3":
                        RemoverTarefa(tarefas);
                        break;
                    case "4":
                        servicoTarefas.SalvarTarefas(tarefas);
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void AdicionarTarefa(List<ItemTarefa> tarefas)
        {
            Console.Clear();
            Console.WriteLine("Adicionar Nova Tarefa");

            Console.Write("Título: ");
            var titulo = Console.ReadLine();

            Console.Write("Descrição: ");
            var descricao = Console.ReadLine();

            tarefas.Add(new ItemTarefa(titulo, descricao));

            Console.WriteLine("Tarefa adicionada com sucesso! Pressione qualquer tecla para continuar.");
            Console.ReadKey();
        }

        static void ListarTarefas(List<ItemTarefa> tarefas)
        {
            Console.Clear();
            Console.WriteLine("Lista de Tarefas");

            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa encontrada.");
            }
            else
            {
                foreach (var tarefa in tarefas)
                {
                    Console.WriteLine(tarefa);
                    Console.WriteLine("---------------------------------------------------");
                }
            }

            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
        }

        static void RemoverTarefa(List<ItemTarefa> tarefas)
        {
            Console.Clear();
            Console.WriteLine("Remover Tarefa");

            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa para remover.");
                Console.WriteLine("Pressione qualquer tecla para continuar.");
                Console.ReadKey();
                return;
            }

            for (int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tarefas[i].Titulo}");
            }

            Console.Write("Escolha o número da tarefa para remover: ");
            if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= tarefas.Count)
            {
                tarefas.RemoveAt(indice - 1);
                Console.WriteLine("Tarefa removida com sucesso! Pressione qualquer tecla para continuar.");
            }
            else
            {
                Console.WriteLine("Número inválido. Pressione qualquer tecla para tentar novamente.");
            }

            Console.ReadKey();
        }
    }
}

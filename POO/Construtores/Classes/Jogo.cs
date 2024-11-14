using System;
using System.Collections.Generic;

namespace Construtores.Classes
{
    public class Jogo
    {
        public string nome { get; set; }
        public int preço { get; set; }
        public string categoria { get; set; }

        public Jogo(string nm, int pr, string ct)
        {
            nome = nm;
            preço = pr;
            categoria = ct;
        }

        public void ExibirDados()
        {
            Console.WriteLine(@$"
            nome: {nome}
            preço: {preço}
            categoria: {categoria}
            ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Jogo> jogos = new List<Jogo>();
            int opcao;

            do
            {
                Console.WriteLine("Menu de Opções:");
                Console.WriteLine("1) Cadastrar Jogo");
                Console.WriteLine("2) Listar Jogos");
                Console.WriteLine("0) Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        // Cadastrar Jogo
                        Console.Write("Digite o nome do jogo: ");
                        string nome = Console.ReadLine();
                        Console.Write("Digite o preço do jogo: ");
                        int preco = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite a categoria do jogo: ");
                        string categoria = Console.ReadLine();

                        Jogo novoJogo = new Jogo(nome, preco, categoria);
                        jogos.Add(novoJogo);
                        Console.WriteLine("Jogo cadastrado com sucesso!");
                        break;

                    case 2:
                        // Listar Jogos
                        Console.WriteLine("Lista de Jogos:");
                        foreach (var jogo in jogos)
                        {
                            jogo.ExibirDados();
                        }
                        break;

                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                Console.WriteLine(); // Adiciona uma linha em branco para melhor legibilidade
            } while (opcao != 0);
        }
    }
}
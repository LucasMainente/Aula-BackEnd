using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using Construtores.Classes;

Console.WriteLine(@$"
+----------------------+
|   PROGRAMA VEÍCULO   |
+----------------------+
");

Veículo carro1 = new Veículo("Ford", "Ka", 2000, "Vermelho");
Veículo carro2 = new Veículo("Ford", "Ka", 2000, "Vermelho");

carro1.ExibirDados();
carro2.ExibirDados();

Console.WriteLine(@$"
+----------------------+
|    PROGRAMA ALUNO    |
+----------------------+
");

Aluno aluno1 = new Aluno("agatha", 16, "torloni");
Aluno aluno2 = new Aluno("kaue", 16, "torloni");
Aluno aluno3 = new Aluno("laura", 17, "torloni");

aluno1.ExibirDados();
aluno2.ExibirDados();
aluno3.ExibirDados();

Console.WriteLine(@$"
+----------------------+
|    PROGRAMA JOGO     |
+----------------------+
");

List<Jogo> EstoqueJogos = new List<Jogo>();

Jogo jogo1 = new Jogo("little nightmares", 80, "terror");
Jogo jogo2 = new Jogo("minecraft", 100, "aventura");
Jogo jogo3 = new Jogo("five night freddy's", 180, "terror");

EstoqueJogos.Add(jogo3);
EstoqueJogos.Add(jogo2);

foreach (var jogo in EstoqueJogos) 
{
    jogo.ExibirDados();
}

int escolha = 0;

do
{
    Console.WriteLine(@$"menu de opcoes
1 - Cadastrar jogo
2 - Listar jogos 
0 - Sair
");

    escolha = int.Parse(Console.ReadLine()!);

    if (escolha == 1)
    {
        Console.WriteLine($"Você escolheu cadastrar jogo");
        
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Cadastro do jogo {i + 1}:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine()!;
            Console.Write("Preco: ");
            int preco = int.Parse(Console.ReadLine()!);
            Console.Write("Gênero: ");
            string genero = Console.ReadLine()!;

            Jogo novoJogo = new Jogo(nome, preco, genero);
            EstoqueJogos.Add(novoJogo);
        }
    }
    else if (escolha == 2)
    {
        Console.WriteLine($"Você escolheu listar jogos");
        foreach (var jogo in EstoqueJogos)
        {
            jogo.ExibirDados();
        }
    }

} while (escolha != 0);

Console.WriteLine($"Você saiu do programa");
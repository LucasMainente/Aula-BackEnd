int qntmulher = 0;
int qnthomen = 0;
int qntGostaEsportes = 0;
int qntNaoGostaEsportes = 0;


Console.WriteLine("Quantas pessoas estão na mesa?");
int totalPessoas;

while (!int.TryParse(Console.ReadLine(), out totalPessoas) || totalPessoas <= 0)
{
    Console.WriteLine("Por favor, insira um número válido de pessoas.");
}

for (int i = 0; i < totalPessoas; i++)
{
    Console.WriteLine($"Pessoa {i + 1}: Digite 'F' para Feminino ou 'M' para Masculino:");
    string sexo = Console.ReadLine();

    if (sexo == "F")
    {
        qntmulher++;
    }
    else if (sexo == "M")
    {
        qnthomen++;
    }
    else
    {
        Console.WriteLine("Entrada inválida. Por favor, digite 'F' ou 'M'.");
        i--; 
        continue; 
    }

    Console.WriteLine("Você gosta de esportes? Digite 'S' para Sim ou 'N' para Não:");
    string gostaEsportes = Console.ReadLine();

    if (gostaEsportes == "S")
    {
        qntGostaEsportes++;
    }
    else if (gostaEsportes == "N")
    {
        qntNaoGostaEsportes++;
    }
    else
    {
        Console.WriteLine("Entrada inválida. Por favor, digite 'S' ou 'N'.");
        i--; 
    }
}

Console.WriteLine($"Total de Mulheres: {qntmulher}");
Console.WriteLine($"Total de Homens: {qnthomen}");
Console.WriteLine($"Total que gostam de esportes: {qntGostaEsportes}");
Console.WriteLine($"Total que não gostam de esportes: {qntNaoGostaEsportes}");
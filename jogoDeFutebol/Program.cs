Console.WriteLine("Quantos gols o time A fez?");
int TimeA = int.Parse(Console.ReadLine());

Console.WriteLine("Quantos gols o time B fez?");
int TimeB = int.Parse(Console.ReadLine());

if (TimeA > TimeB)
{
    Console.WriteLine("Vitória do time A");
}
else if (TimeA < TimeB)
{
    Console.WriteLine("Vitória do time B");
}
else
{
    Console.WriteLine("Empate");
}


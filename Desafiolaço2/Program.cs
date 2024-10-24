int totalHomens=0;
int totalMulheres =0;
int somaidadeHomens =0;
int someidadeMulheres =0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Pessoas {i + 1}:");

    Console.Write("Digite Sua idade :");
    int idade = int.Parse(Console.ReadLine());


    Console.Write("Digite o peso : ");
    float peso = float.Parse(Console.ReadLine());

    Console.Write("Digite o sexo (M-F) :");
    string sexo = string.Parse(Console.ReadLine()!);
    Console.Writeline();



    if (sexo == 'M')

    {
    totalHomens++;
    somaidadeHomens += idade;    
    }
    else if (sexo == 'F')
    {
        totalMulheres++;
        someidadeMulheres += idade;
        }
        else
        {
            Console.WriteLine("Sexo invalido");
        }

}

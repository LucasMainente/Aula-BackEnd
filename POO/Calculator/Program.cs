using Calculator.Classes;

Calculadora calc = new Calculadora();

Console.WriteLine($"Informe a conta que deseja fazer");

Console.WriteLine("1 - Soma");

Console.WriteLine("2 - Subtração");

Console.WriteLine("3 - Multiplicação");

Console.WriteLine("4 - Divisão");

Console.WriteLine("5 - Sair");


Console.Write("Escolha uma opção: ");


int escolha = int.Parse(Console.ReadLine()); 


if (escolha == 1) 
{
    Console.WriteLine($"Informe os numeros da soma");

    float numero1 = float.Parse(Console.ReadLine());

    float numero2 = float.Parse(Console.ReadLine());


    float resultado = calc.Somar(numero1, numero2); 

    Console.WriteLine($"Resultado: {resultado}");

}
else if (escolha == 2) 
{
    Console.WriteLine($"Informe os numeros da Subtração");

    float numero1 = float.Parse(Console.ReadLine());

    float numero2 = float.Parse(Console.ReadLine());

    float resultado = calc.Subtrair(numero1, numero2); 

    Console.WriteLine($"Resultado: {resultado}");

}
else if (escolha == 3) 
{
    Console.WriteLine($"Informe os numeros da Multiplicação");

    float numero1 = float.Parse(Console.ReadLine());

    float numero2 = float.Parse(Console.ReadLine());

    float resultado = calc.Multiplicar(numero1, numero2); 

    Console.WriteLine($"Resultado: {resultado}");
}
else if (escolha == 4)
{
    Console.WriteLine($"Informe os numeros da Divisão");

    float numero1 = float.Parse(Console.ReadLine());

    float numero2 = float.Parse(Console.ReadLine());

    if (numero2 != 0)
    {
        float resultado = calc.Dividir(numero1, numero2); 

        Console.WriteLine($"Resultado: {resultado}");

    }
    else

    {

        Console.WriteLine("Erro: Divisão por zero não é permitida.");

    }

}

else if (escolha == 5) // Added option to exit

{

    Console.WriteLine("Saindo...");

}

else

{

    Console.WriteLine("Opção inválida.");

}

Console.WriteLine($"Informe o lado 1");
float lado1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o lado 2");
float lado2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o lado 3");
float lado3 = float.Parse(Console.ReadLine());

if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine($"O triangulo e Equilatero");
}
else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine($"O triangulo e Isoceles");
}
else
{
    Console.WriteLine($"O triangulo e Escaleno");
}


Console.Write("Digite o número de maçãs compradas: ");
int quantidadeMacas = int.Parse(Console.ReadLine());


double preco;

if (quantidadeMacas < 12)
{
    preco = 0.30;
}
else
{
    preco = 0.25;
}


double valorTotal = quantidadeMacas * preco;


Console.WriteLine("Valor total da compra: R$ " + valorTotal.ToString("F2"));
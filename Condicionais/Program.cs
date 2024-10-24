Console.WriteLine($"Qual seu salario");

string salarioentrada = Console.ReadLine(); 

int salario = int.Parse(salarioentrada); 


Console.WriteLine($"Qual valor da compra ?");

string valorCompraentrada = Console.ReadLine(); 

int valorCompra = int.Parse(valorCompraentrada); 


if(valorCompra <= salario){ 

    Console.WriteLine($"Gastos dentro do orcamento");

} else {

    Console.WriteLine($"Orcamento estourado");
}
using banco.Classes;

int saque;

Console.Clear();
Console.WriteLine($"Bem vindo ao Nubanquinho");
Console.WriteLine();



ContaCorrente contaLucas = new ContaCorrente();
ContaCorrente contaRoberto = new ContaCorrente();

contaLucas.Titular = "Lucas";
contaLucas.Depositar(100000f);

Console.WriteLine($"Conta do {contaLucas.Titular} tem {contaLucas.saldo}");
Console.WriteLine($"Conta do {contaRoberto.Titular} tem {contaRoberto.saldo}");

contaRoberto.Sacar


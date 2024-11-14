using RPGPOO.Classes;
System.Console.Clear();

Personagen persona = new Personagen();



Console.WriteLine($"Bem vindo ao RPGPOO");





Console.Write("Informe o nome do personagem: ");
persona.Nome = Console.ReadLine();

Console.Write("Informe a idade do personagem: ");
persona.Idade = int.Parse(Console.ReadLine());

Console.Write("Informe a armadura do personagem: ");
persona.Armadura = Console.ReadLine();

Console.Write("Informe a I.A. do personagem: ");
persona.IA = Console.ReadLine();


Console.WriteLine($"\nInformações do Personagem: {persona.Nome}{persona.Idade}{persona.Armadura}{persona.IA}");
Console.WriteLine(persona.ToString());

Console.WriteLine($"Selecione a sua escolha");
Console.WriteLine(@$"1 - Atacar
2 - defender 
3 - restaurar armadura
        ");
persona.escolha = int.Parse(Console.ReadLine()!);
if (persona.escolha == 1)
{
    persona.Atacar();

}
else if (persona.escolha == 2)
{
    persona.Defender();
}
else if (persona.escolha == 3)
{
    persona.RestaurarArmadura();
}





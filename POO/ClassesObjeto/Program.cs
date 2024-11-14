


using System.Net.Http.Headers;
using ClasseObjeto.Classes;



Animal cachorro = new Animal();

cachorro.nome = "hanna";
cachorro.raca = "TomBaLata";
cachorro.cor = "branca com manchas marrons";
cachorro.idade = 9;

Animal gato = new Animal();

gato.nome = "sherman";
gato.raca = "Gato de rua";
gato.cor = "laranja";
gato.idade = 12;



Console.WriteLine($"Nome do cachorro {cachorro.nome}");
Console.WriteLine($"IDade do cachorro {cachorro.idade}");
Console.WriteLine($"Cor do cachorrinho {cachorro.cor}");
Console.WriteLine($"Raça do cachorro {cachorro.raca}");

Console.WriteLine($" Nome do gato {gato.nome} \n");
Console.WriteLine($"Raça do gato  {gato.raca}  \n");
Console.WriteLine($"Cor do gato   {gato.cor}    \n");
Console.WriteLine($"Idade do gato {gato.idade}\n");



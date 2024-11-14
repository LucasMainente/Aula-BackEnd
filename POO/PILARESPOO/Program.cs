
using PILARESPOO.Classes.Aprendizagem;

Pessoa IsaacBorges = new Pessoa();

CArro Carro1 = new CArro(); 

Aviao Aviao1 = new Aviao();

Moto Moto1 = new Moto();

IsaacBorges.Matricula = 12345678;


IsaacBorges.Curso = "dev";

IsaacBorges.Media = 7.87F;

IsaacBorges.Aluno = "IsaacBorges";


Console.WriteLine($" O Aluno :{IsaacBorges.Aluno}");


Console.WriteLine($"A media do Alundo é : {IsaacBorges.Media}");

Console.WriteLine($"O curso que o aluno esta fazendo é :{IsaacBorges.Curso}");

Console.WriteLine($"A matricula do aluno é : {IsaacBorges.Matricula}");



Carro1.Marca = "Ferrari";
Carro1.Modelo = "LaFerrari";
Carro1.Cor = "Vermelho";
Carro1.Potencia = 640;
Carro1.qtdPAssageiros = 4;
Carro1.qtdPortas = 2;


Aviao1.Marca = "Boieng";
Aviao1.Modelo = "747";
Aviao1.Cor = "Branco";
Aviao1.Potencia = 165000;
Aviao1.qtdPAssageiros = 440;
Aviao1.qtdPortas = 44;

Moto1.Marca = "BMW";
Moto1.Modelo = "S1000";
Moto1.Cor = "Azul";
Moto1.Potencia = 110;
Moto1.qtdPAssageiros = 2;


Console.WriteLine($"O {Carro1}");
Console.WriteLine($"O {Aviao1}");
Console.WriteLine($"O {Moto1}");













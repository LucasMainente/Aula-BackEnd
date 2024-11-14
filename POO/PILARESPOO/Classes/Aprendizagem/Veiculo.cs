using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PILARESPOO.Classes.Aprendizagem
{
    public abstract class Veiculo
    {
        public string? Marca;

        public string? Modelo;

        public string? Cor;

        public int Potencia;

        public int qtdPAssageiros;

        public void Ligar(){

            Console.WriteLine($"O {Modelo} Esta ligando");
        }

        public void Desligar(){

            Console.WriteLine($"O {Modelo} esta desligando");

        }

        public void Buzinar(){

            Console.WriteLine($"O {Modelo} esta buzinando");
            

        }




    }
}
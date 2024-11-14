using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace PILARESPOO.Classes.Aprendizagem
{
    public class Professor : Pessoa
    {
        public  int Nif { get ; set ;}


        public float Salario {get ; set ;}
        

        public Professor(int _nif)
        {
            Nif = _nif;
        }
    }
}
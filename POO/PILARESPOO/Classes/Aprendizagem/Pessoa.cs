using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PILARESPOO.Classes.Aprendizagem
{
    public class Pessoa : 
    {

        public string Aluno;
        public int Idade;

        public string cpf;

        public float Peso {get ; set ;}

        public float Altura {get ; set ;}

        public int Matricula;

        public string Curso;

        public float Media {get ; set ;}


        public void Envelhecer(){

            Idade++;

        }

        public void Engordar(float _kg){

            Peso = Peso + _kg;

        }

        public void Emagrecer(float _kg){

            Peso = Peso - _kg;

        }


    }
}
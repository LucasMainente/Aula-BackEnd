
namespace banco.Classes
{
    public class ContaCorrente
    {
        public int NumeroConta;

        public string? Titular;
    
        public float saldo = 0;
    

        public void Depositar(float valor)
        {

            saldo = saldo + valor;


        }

        public void Sacar(float valor)
        {
            saldo = saldo - saque;
        }

    }



}
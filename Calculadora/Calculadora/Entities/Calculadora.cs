

namespace Calculadora.Entities
{
    internal class Calculadora
    {
        public double PrimeiroValor {  get; set; }
        public double SegundoValor { get; set; }

        public Calculadora()
        {

        }

        public Calculadora(double primeiroValor, double segundoValor)
        {
            PrimeiroValor = primeiroValor;
            SegundoValor = segundoValor;
        }
    }
}

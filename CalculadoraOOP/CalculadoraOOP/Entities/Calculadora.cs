

namespace CalculadoraOOP.Entities
{
    internal class Calculadora
    {
        public int Valor1 { get; set; }
        public int Valor2 { get; set; }

        public Calculadora()
        {

        }

        public Calculadora(int valor1, int valor2)
        {
            valor1 = Valor1;
            valor2 = Valor2;
        }

        public double Subtração(int valor1, int valor2)
        {
            return (double)valor1 - valor2;

        }
        public double Adição(int valor1, int valor2)
        {
            return (double)valor1 + valor2;

        }
        public double Multiplicação(int valor1, int valor2)
        {
            return (double)valor1 * valor2;

        }
        public double Divisão(int valor1, int valor2)
        {
            return (double)valor1 / valor2;

        }
        public double Potenciação(int valor1, int valor2)
        {
            return (double)Math.Pow(valor1, valor2);

        }
    }
}

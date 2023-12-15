using CalculadoraOOP.Entities;
using System;

namespace CalculadoraOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora iniciada!");
            Inicio();

            static void Inicio()
            {
                Console.WriteLine("Qual operação vai ser utilizada?");
                Console.WriteLine();
                Console.WriteLine("0 - Encerrar");
                Console.WriteLine("1 - Subtração");
                Console.WriteLine("2 - Adição");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Potenciação");
                Console.WriteLine();


                Console.Write("Digite a sua opção: ");
                int validação = int.Parse(Console.ReadLine());
                Console.WriteLine();


                if (validação < 0 || validação > 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção invalida.");
                    Console.WriteLine();
                    Inicio();
                   
                }
                else if (validação == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Programa encerrado!");
                    Environment.Exit(0);
                }

                Console.Write("Digite o primeiro valor: ");
                int valor1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo valor OU potencia: ");
                int valor2 = int.Parse(Console.ReadLine());
                Calculadora calculadora = new Calculadora(valor1, valor2);

                if (validação == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Resultado = " + calculadora.Subtração(valor1, valor2));
                    Console.WriteLine();
                    Inicio();

                }
                if (validação == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Resultado = " + calculadora.Adição(valor1, valor2));
                    Console.WriteLine();
                    Inicio();
                }
                if (validação == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Resultado = " + calculadora.Multiplicação(valor1, valor2));
                    Console.WriteLine();
                    Inicio();
                }
                if (validação == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Resultado = " + calculadora.Divisão(valor1, valor2));
                    Console.WriteLine();
                    Inicio();
                }
                if (validação == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Resultado = " + calculadora.Potenciação(valor1, valor2));
                    Console.WriteLine();
                    Inicio();
                }
            }







        }
    }
}
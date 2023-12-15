using System;
using System.Security.Cryptography.X509Certificates;

namespace Calculdora
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação vai ser utilizada?");
            Inicio();
            
            static void Inicio()
            {
                Console.WriteLine("0 - Encerrar");
                Console.WriteLine("1 - Subtração");
                Console.WriteLine("2 - Adição");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Potenciação");
                Console.WriteLine();

                Console.Write("Digite a sua opção: ");
                int validação = int.Parse(Console.ReadLine());

                while (validação < 0 || validação > 5)
                {

                    Console.WriteLine();
                    Console.WriteLine("Opção invalida.");
                    Console.WriteLine();

                    Console.WriteLine("Qual operação vai ser utilizada?");
                    Console.WriteLine("0 - Encerrar");
                    Console.WriteLine("1 - Subtração");
                    Console.WriteLine("2 - Adição");
                    Console.WriteLine("3 - Multiplicação");
                    Console.WriteLine("4 - Divisão");
                    Console.WriteLine("5 - Potenciação");
                    Console.WriteLine();

                    Console.Write("Digite a sua opção ou digite Encerrar: ");
                    validação = int.Parse(Console.ReadLine());
                }

                if (validação == 1)
                {
                    Subtração();
                }
                if (validação == 2)
                {
                    Adição();
                }
                if (validação == 3)
                {
                    Multiplicação();
                }
                if (validação == 4)
                {
                    Divisão();
                }
                if (validação == 5)
                {
                    Potenciação();
                }
                if (validação == 0)
                {
                    Console.WriteLine("Programa encerrado!");
                }
                

            }
            
            static void Subtração()
            {
                Console.Write("Insira o primeiro valor: ");
                double valor1 = double.Parse(Console.ReadLine());
                Console.Write("Insira o segundo valor: ");
                double valor2 = double.Parse(Console.ReadLine());

                double resultado = valor1 - valor2;
                Console.WriteLine("O resultado é = " + resultado);
                Console.WriteLine();
                Inicio();


            }

            static void Adição()
            {
                Console.Write("Insira o primeiro valor: ");
                double valor1 = double.Parse(Console.ReadLine());
                Console.Write("Insira o segundo valor: ");
                double valor2 = double.Parse(Console.ReadLine());

                double resultado = valor1 + valor2;
                Console.WriteLine("O resultado é = " + resultado);
                Console.WriteLine();
                Inicio();

            }

            static void Multiplicação()
            {
                Console.Write("Insira o primeiro valor: ");
                double valor1 = double.Parse(Console.ReadLine());
                Console.Write("Insira o segundo valor: ");
                double valor2 = double.Parse(Console.ReadLine());

                double resultado = valor1 * valor2;
                Console.WriteLine("O resultado é = " + resultado);
                Console.WriteLine();
                Inicio();

            }
            static void Divisão()
            {
                Console.Write("Insira o primeiro valor: ");
                double valor1 = double.Parse(Console.ReadLine());
                Console.Write("Insira o segundo valor: ");
                double valor2 = double.Parse(Console.ReadLine());

                double resultado = valor1 / valor2;
                Console.WriteLine("O resultado é = " + resultado);
                Console.WriteLine();
                Inicio();

            }

            static void Potenciação()
            {
                Console.Write("Insira o primeiro valor: ");
                double valor1 = double.Parse(Console.ReadLine());
                Console.Write("Insira o valor de potencia: ");
                double potencia = double.Parse(Console.ReadLine());

                double resultado = Math.Pow(valor1, potencia);
                Console.WriteLine("O resultado é = " + resultado);
                Console.WriteLine();
                Inicio();
                
            }




        }
    }
}
    

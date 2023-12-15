using SomarContas.Entities;
using System;
using System.Globalization;

namespace SomaContas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao somador de contas!");
            Console.WriteLine();
            
            List<Account> accounts = new List<Account>();
            Account account = new Account();

            Console.Write("Quantas contas serão calculadas? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Conta #" + i);
                Console.Write("Nome da companhia: ");
                string nameCompany = Console.ReadLine();
                Console.Write("Serviço da companhia: ");
                string typeCompany = Console.ReadLine();
                Console.Write("Valor total da conta: ");
                double priceAccount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Data de vencimento da conta (dd/MM/yyyy): ");
                DateTime maturity = DateTime.Parse(Console.ReadLine());
                Company company = new Company(nameCompany,typeCompany);
                accounts.Add(new Account(company, priceAccount, maturity));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Lista de contas a pagar:");
            Console.WriteLine();
            foreach (Account account1 in accounts)
            {
                Console.WriteLine(account1 + " - " + "Vencimento em: " + account.DiasVencimento(account1.Maturity) + " Dia(s)");

            }

            Console.WriteLine();
            Console.Write("Total das contas: " + account.Total(accounts).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            

            

        }
    }
}

using SimpleAccountBank.Conts;
using System;

namespace CSharpExampleAndTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //entrando com os dados de criacao de uma nova conta
            Console.WriteLine("Create the account");
            Console.Write("Name of the Bank: ");
            string nameBank = Console.ReadLine();
            Console.Write("Agency: ");
            int agency = int.Parse(Console.ReadLine());
            Console.Write("Account: ");
            int account = int.Parse(Console.ReadLine());
            DateTime dateTime = DateTime.Now;
            Console.Write("Id client: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("CPF: ");
            int cpf = int.Parse(Console.ReadLine());
            Console.Write("Name of the client: ");
            string name = Console.ReadLine();
            Console.Write("brithDate('yyyy/MM/day'): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            //instaciando em memoria
            Banc banc = new Banc (nameBank, agency, account,dateTime, id, cpf, name, birthDate);
            // exibir resultado
            Console.WriteLine();
            Console.WriteLine("Create Account");
            Console.WriteLine(banc);
            Console.ReadLine();
        }
    }
}
//Exemplo
//Create the account
//Name of the Bank: Banco Central
//Agency: 3344
//Account: 678543
//Id client:001
//CPF: 00834567245
//Name of the client: Paul Mcgreery
//brithDate('yyyy/MM/day'): 1993/12/03

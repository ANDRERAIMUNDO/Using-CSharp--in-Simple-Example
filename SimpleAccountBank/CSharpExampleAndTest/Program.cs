using SimpleAccountBank;
using SimpleAccountBank.Conts;
using SimpleAccountBank.Enum;
using System;

namespace CSharpExampleAndTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //entrando com os dados de criacao de uma nova conta
            Console.WriteLine("Create the account");

            try
            {

                Console.Write("Type of the Account: ");
                Enum_TypeAccount typeAccount = Enum.Parse<Enum_TypeAccount>(Console.ReadLine());
                Console.Write("Name of the Bank: ");
                string nameBank = Console.ReadLine();
                Console.Write("Agency: ");
                int agency = int.Parse(Console.ReadLine());
                Console.Write("Account: ");
                int account = int.Parse(Console.ReadLine());
                Console.Write("Digit: ");
                int digit = int.Parse(Console.ReadLine());
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
                Banc banc = new Banc(typeAccount, nameBank, agency, account, digit, dateTime, id, cpf, name, birthDate);
                // exibir resultado
                Console.WriteLine();
                Console.WriteLine("Create Account");
                Console.WriteLine("Bank " + banc.Name);
                Console.WriteLine("Ageny: " + banc.Agency);
                Console.WriteLine(" Account: " + banc.Account + " - " + banc.Digit.ToString());
                Console.WriteLine("Type Acconut: " + typeAccount);
                Console.WriteLine("ID: " + banc.Users.Id.ToString());
                Console.WriteLine("CPF: " + banc.Users.Cpf.ToString());
                Console.WriteLine("Client: " + banc.Users.Name);
                Console.WriteLine("Brith Date: " + banc.Users.BirthDate);
                Console.WriteLine("Date this operation: " + banc.Users.DateTime);
            }

            catch (FormatException e)
            {
                Console.WriteLine("error has occurred"  + e.Message);
                return;
            }
            Console.ReadLine();
        }
    }
}
//Exemplo
//Create the account
//Name of the Bank: Banco Central
//Agency: 3344
//Account: 678543
//Digit :0
//CheckingAccount our SavingsAccount
//Id client:001
//CPF: 00834567245
//Name of the client: Paul Mcgreery
//brithDate('yyyy/MM/day'): 1993/12/03

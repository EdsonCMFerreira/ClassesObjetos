using System;

namespace ClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            // tipo inteiro
            Program prog = new Program();

            House house1 = new House();
            house1.Address = "Rua xyz, 123";
            house1.Color = "verde";

            BankAccount bankAccount = new BankAccount();
            bankAccount.PersonName = "Juca bala";
            bankAccount.Deposit(200);  // Correção: Chamando o método Deposit corretamente
        }
    }

    public class House
    {
        public string Address;
        public string Color;

        public void TurnLightsOn()
        {
            Console.WriteLine("Luzes ligadas.");  // Correção: Removendo o parâmetro value
        }

        public void TurnLightsOff()
        {
            Console.WriteLine("Luzes desligadas.");
        }
    }

    public class BankAccount
    {
        public string PersonName;
        public decimal Balance;

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"{PersonName} possui saldo de {Balance:C2}");
        }
    }
}

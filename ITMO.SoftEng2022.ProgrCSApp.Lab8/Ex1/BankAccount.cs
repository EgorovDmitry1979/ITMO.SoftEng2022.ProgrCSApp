using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITMO.SoftEng2022.ProgrCSApp.Lab8Ex1 //Разработка конструкторов
{
    public enum AccountType { Checking, Deposit }
    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;

        private static long nextAccNo = 123;

        public void TransferFrom(BankAccount accFrom, decimal amount)
        {
            if (accFrom.Withdraw(amount))
                this.Deposit(amount);
        }

        public decimal Deposit(decimal amount)
        {
            accBal += amount;
            return accBal;
        }

        public BankAccount() //new lab8.1.2
        {
            accNo = NextNumber(); //new lab8.1.2
            accType = AccountType.Checking; //new lab8.1.2
            accBal = 0; //new lab8.1.2
        }

        public BankAccount(AccountType aType) //new lab8.1.2
        {
            accNo = NextNumber(); //new lab8.1.2
            accType = aType; //new lab8.1.2
            accBal = 0; //new lab8.1.2
        }

        public BankAccount(decimal aBal) //new lab8.1.2
        {
            accNo = NextNumber(); //new lab8.1.2
            accType = AccountType.Checking; //new lab8.1.2
            accBal = aBal; //new lab8.1.2
        }

        public BankAccount(AccountType aType, decimal aBal) //new lab8.1.2
        {
            accNo = NextNumber(); //new lab8.1.2
            accType = aType; //new lab8.1.2
            accBal = aBal; //new lab8.1.2
        }

        public bool Withdraw(decimal amount)
        {
            bool sufficientFunds = accBal >= amount;
            if (sufficientFunds)
            {
                accBal -= amount;
            }
            return sufficientFunds;
        }

        public long Number()
        {
            return accNo;
        }
        public decimal Balance()
        {
            return accBal;
        }
            public string Type()
        {
            return accType.ToString();
        }
            private static long NextNumber()
        {
            return nextAccNo++;
        }

    }
    class CreateAccount
    {
        public static void TestDeposit(BankAccount acc)
        {
            Console.Write("Enter amount to deposit (Введите сумму для зачисления): ");
            decimal amount = decimal.Parse(Console.ReadLine());
            acc.Deposit(amount);
        }

        public static void TestWithdraw(BankAccount acc)
        {
            Console.Write("Enter amount to withdraw (Введите сумму для снятия): ");
            decimal amount = decimal.Parse(Console.ReadLine());
            if (!acc.Withdraw(amount))
            {
                Console.WriteLine("Insufficient funds (Недостаточно средств).");
            }
        }

        static void Main()
        {

            BankAccount acc1, acc2, acc3, acc4; //new lab8.1.3

            acc1 = new BankAccount(); //new lab8.1.3
            acc2 = new BankAccount(AccountType.Deposit); //new lab8.1.3
            acc3 = new BankAccount(100); //new lab8.1.2
            acc4 = new BankAccount(AccountType.Deposit, 500); //new lab8.1.3

            Write(acc1); //new lab8.1.3
            Write(acc2); //new lab8.1.3
            Write(acc3); //new lab8.1.3
            Write(acc4); //new lab8.1.3
        }
        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();

            Console.Write("Enter the account balance! (Введите баланс счета!): ");
            decimal balance = decimal.Parse(Console.ReadLine());

            return created;
        }

        static void Write(BankAccount toWrite)
        { 
            Console.WriteLine("Account number is (Номер счета) {0}", toWrite.Number());
            Console.WriteLine("Account balance is (Баланс счета) {0}", toWrite.Balance());
            Console.WriteLine("Account type is (Тип счета) {0}", toWrite.Type());
        }
    }
}

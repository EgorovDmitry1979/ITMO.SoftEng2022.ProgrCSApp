using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections; //newlab8.2.3

namespace ITMO.SoftEng2022.ProgrCSApp.Lab8Ex2 //Создаnm метод TransferFrom. На базе 7.1.1.!!!
{
    public class BankTransaction //newlab8.2.1
    {
        private readonly decimal amount;
        private readonly DateTime when;

        public BankTransaction(decimal tranAmount) //newlab8.2.2
        {
            amount = tranAmount; //newlab8.2.2
            when = DateTime.Now; //newlab8.2.2
        }

        public decimal Amount()
        {
            return amount;
        }

        public DateTime When()
        {
            return when;
        }
    }

    public enum AccountType { Checking, Deposit }

    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;

        private static long nextAccNo = 123;

        private Queue tranQueue = new Queue(); //newlab8.2.3

        public Queue Transactions() //newlab8.2.4
        {
            return tranQueue; //newlab8.2.4
        }

        public void TransferFrom(BankAccount accFrom, decimal amount)
        {
            if (accFrom.Withdraw(amount))
                this.Deposit(amount);
        }

        public decimal Deposit(decimal amount)
        {
            accBal += amount;
            BankTransaction tran = new BankTransaction(amount); //newlab8.2.3
            tranQueue.Enqueue(tran); //newlab8.2.3
            return accBal;
        }

        public void Populate(decimal balance)
        {
            accNo = NextNumber();
            accBal = balance;
            accType = AccountType.Checking;
        }

        public bool Withdraw(decimal amount)
        {
            bool sufficientFunds = accBal >= amount;
            if (sufficientFunds)
            {
                accBal -= amount;
                BankTransaction tran = new BankTransaction(-amount); //newlab8.2.3
                tranQueue.Enqueue(tran); //newlab8.2.3
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
            BankAccount berts = NewBankAccount();
            Write(berts);
            TestDeposit(berts);
            Write(berts);
            TestWithdraw(berts);
            Write(berts);

            BankAccount freds = NewBankAccount();
            Write(freds);
            TestDeposit(freds);
            Write(freds);
            TestWithdraw(freds);
            Write(freds);
        }
        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();

            Console.Write("Enter the account balance! (Введите баланс счета!): ");
            decimal balance = decimal.Parse(Console.ReadLine());

            created.Populate(balance);

            return created;
        }

        //static void Write(BankAccount toWrite) //newlab8.2.4
        //{ 
        //    Console.WriteLine("Account number is (Номер счета) {0}", toWrite.Number());
        //    Console.WriteLine("Account balance is (Баланс счета) {0}", toWrite.Balance());
        //    Console.WriteLine("Account type is (Тип счета) {0}", toWrite.Type());
        //}

        static void Write(BankAccount acc) //newlab8.2.4
        {
            Console.WriteLine("Account number is (Номер счета) {0}", acc.Number()); //newlab8.2.4
            Console.WriteLine("Account balance is (Баланс счета) {0}", acc.Balance()); //newlab8.2.4
            Console.WriteLine("Account type is (Тип счета) {0}", acc.Type()); //newlab8.2.4
            Console.WriteLine("Transactions (Транзакции):"); //newlab8.2.4
            foreach (BankTransaction tran in acc.Transactions()) //newlab8.2.4
            {
                Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount()); //newlab8.2.4
            }
            Console.WriteLine(); //newlab8.2.4
        }
    }
}

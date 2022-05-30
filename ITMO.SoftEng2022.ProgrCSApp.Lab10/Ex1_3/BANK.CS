using System.Collections;
public class Bank
{
    public long CreateAccount()
    {
        BankAccount newAcc = new BankAccount();
        long accNo = newAcc.Number();
        accounts[accNo] = newAcc;
        return accNo;
    }

    public long CreateAccount(AccountType aType, decimal aBal) //10.1.3.
    {
        BankAccount newAcc = new BankAccount(); //10.1.3.
        long accNo = newAcc.Number(); //10.1.3.
        accounts[accNo] = newAcc; //10.1.3.
        return accNo; //10.1.3.
    }

        public long CreateAccount(AccountType aType) //10.1.3.
    {
        BankAccount newAcc = new BankAccount(); //10.1.3.
        long accNo = newAcc.Number(); //10.1.3.
        accounts[accNo] = newAcc; //10.1.3.
        return accNo; //10.1.3.
    }

    public long CreateAccount(decimal aBal) //10.1.3.
    {
        BankAccount newAcc = new BankAccount(); //10.1.3.
        long accNo = newAcc.Number(); //10.1.3.
        accounts[accNo] = newAcc; //10.1.3.
        return accNo; //10.1.3.
    }

    public bool CloseAccount(long accNo)
    {
        BankAccount closing = (BankAccount)accounts[accNo];
        if (closing != null)
        {
            accounts.Remove(accNo);
            closing.Dispose();
            return true;
        }
        else
        {
            return false;
        }
    }
    private static Hashtable accounts = new Hashtable();

        public BankAccount GetAccount(long accNo)
    {
        return (BankAccount)accounts[accNo];
    }

}

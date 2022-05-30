using System.Collections; //10.1.2
public class Bank
{
    public long CreateAccount() //10.1.2
    {
        BankAccount newAcc = new BankAccount(); //10.1.2
        long accNo = newAcc.Number(); //10.1.2
        accounts[accNo] = newAcc; //10.1.2
        return accNo; //10.1.2
    }
    public bool CloseAccount(long accNo) //10.1.2
    {
        BankAccount closing = (BankAccount)accounts[accNo]; //10.1.2
        if (closing != null) //10.1.2
        {
            accounts.Remove(accNo); //10.1.2
            closing.Dispose(); //10.1.2
            return true; //10.1.2
        }
        else //10.1.2
        {
            return false; //10.1.2
        }
    }
    private static Hashtable accounts = new Hashtable(); //10.1.2

        public BankAccount GetAccount(long accNo) //10.1.2
    {
        return (BankAccount)accounts[accNo]; //10.1.2
    }

}

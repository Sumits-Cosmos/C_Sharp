// lets implement a bank account object with these attributes: 
    // It has a 10-digit number that uniquely identifies the bank account.

    // It has a string that stores the name or names of the owners.

    // The balance can be retrieved.

    // It accepts deposits.

    // It accepts withdrawals.

    // The initial balance must be positive.

    // Withdrawals cannot result in a negative balance.

using System.Collections.Generic;
public class BankAccount
{
    //properties : account_number : number, owner_name : string, balance : number
    public string AccountNumber {get;}
    public string OwnerName {get; set;}
    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
            }
            return balance;
        }}

    List<Transactions>allTransactions = new List<Transactions>();

    //constructor 
    public BankAccount(string OwnerName, decimal initialBalance)
    {
        if(initialBalance < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(initialBalance), "Initial balance must be positive");
        }
        long accountNumber =  Random.Shared.NextInt64(1_000_000_000L, 10_000_000_000L);
        this.AccountNumber = accountNumber.ToString();
        this.OwnerName = OwnerName;
        MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
    }

    //Functions / Methods
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if(amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Deposit Amount must be positive or greater than 0");
        }
        var deposit = new Transactions(amount, date, note);
        allTransactions.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        if(amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount must be greater than 0");
        }
        var withdrawal =  new Transactions(-amount, date, note);
        allTransactions.Add(withdrawal);
    }
}

//make a class transaction that keeps the history of the transactions 
public class Transactions
{
    public decimal Amount {get;}
    public DateTime Date {get;}
    public string Notes {get;}

    public Transactions(decimal amount, DateTime date, string notes)
    {
        this.Amount = amount;
        this.Date = date;
        this.Notes = notes;
    }
}

class Bank
{
    static void Main(string [] args)
    {
        var account = new BankAccount("Sumit Raj", 15000m);
        Console.WriteLine($"Account Number: {account.AccountNumber} was created for {account.OwnerName} with an initial balance of Rs {account.Balance}.");
        account.MakeWithdrawal(5000m, DateTime.Now, "Rent Payment");
        Console.WriteLine($"Account Number: {account.AccountNumber} has a balance of Rs {account.Balance} after withdrawal.");
        account.MakeDeposit(100000m, DateTime.Now, "Salary Deposit");
        Console.WriteLine($"Account Number: {account.AccountNumber} has a balance of Rs {account.Balance} after deposit.");
    }
}
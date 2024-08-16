using System;

class BankAccount
{
    public string AccountNumber { get; }
    public double Balance { get; private set; }

    public BankAccount(string accountNumber, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Ваш рахунок {AccountNumber} поповнено на {amount} грн. Поточний баланс: {Balance} грн.");
        }
        else
        {
            Console.WriteLine("Сума поповнення має бути більше нуля.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"З вашого рахунку {AccountNumber} знято {amount} грн. Поточний баланс: {Balance} грн.");
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Сума зняття має бути більше нуля.");
        }
        else
        {
            Console.WriteLine("Недостатньо коштів на рахунку.");
        }
    }

    public void ShowAccountInfo()
    {
        Console.WriteLine($"Інформація про рахунок {AccountNumber}:");
        Console.WriteLine($"Баланс: {Balance} грн.");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount("12345", 1000.0);

        account.ShowAccountInfo();

        account.Deposit(500.0);
        account.Withdraw(200.0);
        account.Withdraw(1500.0);

        account.ShowAccountInfo();
    }
}

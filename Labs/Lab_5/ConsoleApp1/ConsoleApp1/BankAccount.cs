using System;

class BankAccount
{
    public string Owner;
    public double Balance;

    public BankAccount(string owner, double initialBalance)
    {
        Owner = owner;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Пополнение: +{amount}. Баланс: {Balance}");
        }
        else
        {
            Console.WriteLine("Ошибка: сумма пополнения должна быть положительной!");
        }
    }

    public bool Withdraw(double amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine($"Ошибка: недостаточно средств! Баланс: {Balance}, запрос: {amount}");
            return false;
        }
        Balance -= amount;
        Console.WriteLine($"Снятие: -{amount}. Баланс: {Balance}");
        return true;
    }

    public void Print()
    {
        Console.WriteLine($"Счёт владельца \"{Owner}\": баланс = {Balance}");
    }
}
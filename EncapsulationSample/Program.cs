class BankAccount
{
    private decimal _balance;
    public decimal Balance
    {
        get { return _balance; }
        private set
        {
            if (value >= 0)
                _balance = value;
        }
    }

    public BankAccount(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0) {
            Balance += amount;
        }
    }

    public bool Withdraw(decimal amount) {
        if (amount > 0 && Balance >= 0) { 
            Balance -= amount;
            return true;
        }
        return false;
    }
}
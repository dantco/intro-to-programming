namespace Banking.Domain;

public enum BankAccountType { Standard, Gold };
public class BankAccount
{
    public BankAccountType AccountType = BankAccountType.Standard;
    private decimal _balance = 5000; //  "Fields" "class level variables"
    public void Deposit(decimal amountToDeposit)
    {
        decimal bonus = 0;
        if(AccountType== BankAccountType.Standard)
        {
            bonus = 0;
        }
        else
        {
            bonus = amountToDeposit * .10m;
        }
        _balance += amountToDeposit + bonus;
    }

    public decimal GetBalance()
    {
        return _balance; 
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        if (amountToWithdraw > _balance)
        {
            // TODO
            throw new OverdraftException();
        }
        else
        {
            _balance -= amountToWithdraw;
        }
    }
}
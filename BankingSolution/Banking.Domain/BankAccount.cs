namespace Banking.Domain;

public class BankAccount
{
   
    private decimal _balance = 5000; //  "Fields" "class level variables"
    public void Deposit(decimal amountToDeposit)
    {
        
        _balance += amountToDeposit;
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
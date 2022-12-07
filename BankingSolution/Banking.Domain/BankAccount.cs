namespace Banking.Domain;

public class BankAccount

{
    private readonly ICalculateBonuses _calculator;
    private decimal _balance = 5000; //  "Fields" "class level variables"

    public BankAccount(ICalculateBonuses calculator)
    {
        _calculator = calculator;
    }

    public void Deposit(decimal amountToDeposit)
    {
        // If the balance >= 5000 then give them a bonus
        //decimal bonus = _balance >= 5000M ? amountToDeposit * .10M : 0;
        // Write the Code You Wish You Had
        // decimal bonus = _bonusCalculator.GetBonusForDepositOn(_balance, amountToDeposit);
        
        var bonus = _calculator.GetBonusForDepositOn(_balance, amountToDeposit);
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
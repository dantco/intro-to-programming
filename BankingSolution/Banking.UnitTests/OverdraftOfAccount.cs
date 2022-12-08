


namespace Banking.UnitTests;

public class OverdraftOfAccount
{

    private readonly BankAccount _account;

    public OverdraftOfAccount()
    {
        _account = new BankAccount(new Mock<ICalculateBonuses>().Object,
            new Mock<INotifyAccountReps>().Object);
    }

    [Fact] // Safety Net - an "Invariant"
    public void CanTakeAllTheMoney()
    {
       

        _account.Withdraw(_account.GetBalance());

        Assert.Equal(0, _account.GetBalance());
    }

    [Fact]
    public void OverdraftDoesNotDecreaseTheBalance()
    {
       
        var openingBalance = _account.GetBalance();
        var amountToWithDraw = openingBalance + .01M;

        // Exceptional Behavior
        try
        {
            _account.Withdraw(amountToWithDraw); //  "No-op"
        }
        catch (OverdraftException)
        {

            // Ignore it.
        }

        Assert.Equal(openingBalance, _account.GetBalance());
    }

    [Fact]
    public void OverdraftThrowsAnOverdraftException()
    {
     

        Assert.Throws<OverdraftException>(() =>
        {
            _account.Withdraw(_account.GetBalance() + .51M);
        });
    }
}
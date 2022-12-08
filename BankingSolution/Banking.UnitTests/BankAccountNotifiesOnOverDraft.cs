
namespace Banking.UnitTests;

public class BankAccountNotifiesOnOverDraft
{
    [Fact]
    public void TheBankAccountNotifiesIfThereIsAnOverdraft()
    {
        var mockedNotifer = new Mock<INotifyAccountReps>();
        var account = new BankAccount(new Mock<ICalculateBonuses>().Object, mockedNotifer.Object);
        var openingBalance = account.GetBalance();
        var amountToWithdraw = openingBalance + 1M;

        try
        {
            account.Withdraw(amountToWithdraw);
        }
        catch (Exception) { }

        mockedNotifer.Verify(m => m.NotifyOfAttemptedOverdraft(account, openingBalance, amountToWithdraw), Times.Once());
    }

    [Fact]
    public void TheBankAccountDoesNotNotifyIfThereIsNoOverdraft()
    {
        var mockedNotifer = new Mock<INotifyAccountReps>();
        var account = new BankAccount(new Mock<ICalculateBonuses>().Object, mockedNotifer.Object);
        var openingBalance = account.GetBalance();
        var amountToWithdraw = openingBalance - 1M;

        try
        {
            account.Withdraw(amountToWithdraw);
        }
        catch (Exception) { }

        mockedNotifer.Verify(m => m.NotifyOfAttemptedOverdraft(account, openingBalance, amountToWithdraw), Times.Never());
    }
}

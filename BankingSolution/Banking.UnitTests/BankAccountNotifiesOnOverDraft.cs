
namespace Banking.UnitTests;

public class BankAccountNotifiesOnOverdraft
{

    [Fact]
    public void TheBankAccountNotifiesIfThereIsAnOverdraft()
    {
        var mockedNotifier = new Mock<INotifyAccountReps>();
        var account = new BankAccount(new Mock<ICalculateBonuses>().Object, mockedNotifier.Object);
        var openingBalance = account.GetBalance();
        var amountToWithdraw = openingBalance + 1M;

        try
        {
            account.Withdraw(amountToWithdraw); // Force an overdraft.
        }
        catch (Exception)
        {
            // ignore it
            
        }

        // Verify the notifier was called
        mockedNotifier.Verify(m => m.NotifyOfAttemptedOverdraft(account, openingBalance, amountToWithdraw), Times.Once());

    }

    [Fact]
    public void TheBankAccountDoesNotNotifyIfThereIsNoOverdraft()
    {
        var mockedNotifier = new Mock<INotifyAccountReps>();
        var account = new BankAccount(new Mock<ICalculateBonuses>().Object, mockedNotifier.Object);
        var openingBalance = account.GetBalance();
        var amountToWithdraw = openingBalance - 1M;

            account.Withdraw(amountToWithdraw); // Force an overdraft.
      


        // Verify the notifier was called
        mockedNotifier.Verify(m => m.NotifyOfAttemptedOverdraft(account, openingBalance, amountToWithdraw), Times.Never());


    }
}

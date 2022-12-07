
namespace Banking.UnitTests;

public class WorkingWithMultipleAccounts
{
    [Fact]
    public void InstancesOfOurAccountAreIsolated()
    {
        var bobsAccount = new BankAccount();
        var suesAccount = new BankAccount();

        bobsAccount.Deposit(1000M);
        suesAccount.Withdraw(suesAccount.GetBalance());

        Assert.Equal(6000, bobsAccount.GetBalance());
        Assert.Equal(0, suesAccount.GetBalance());

    }
}

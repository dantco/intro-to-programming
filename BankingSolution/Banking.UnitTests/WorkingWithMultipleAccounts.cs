
using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests;

public class WorkingWithMultipleAccounts
{
    [Fact]
    public void InstancesOfOurAccountAreIsolated()
    {
        var bobsAccount = new BankAccount(new DummyBonusCalculator(), new Mock<INotifyAccountReps>().Object);
        var suesAccount = new BankAccount(new DummyBonusCalculator(), new Mock<INotifyAccountReps>().Object);

        bobsAccount.Deposit(1000M);
        suesAccount.Withdraw(suesAccount.GetBalance());

        Assert.Equal(6000, bobsAccount.GetBalance());
        Assert.Equal(0, suesAccount.GetBalance());

    }
}

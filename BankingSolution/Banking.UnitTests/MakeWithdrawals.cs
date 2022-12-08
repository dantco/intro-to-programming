
using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests;

public class MakeWithdrawals
{
    [Theory]
    [InlineData(500)]
    [InlineData(1000)]
    public void MakingWithdrawalsDecreasesBalance(decimal amountToWithdraw)
    {
        //given
        var account = new BankAccount(new DummyBonusCalculator(), new Mock<INotifyAccountReps>().Object);
        var openingBalance = account.GetBalance();
        //when
        account.Withdraw(amountToWithdraw);
        //then
        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
    }
}

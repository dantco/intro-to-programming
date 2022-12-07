namespace Banking.UnitTests;

public class MakeDeposits
{
    [Theory]
    [InlineData(100)]
    [InlineData(50)]
    public void MakingDepositsIncreasesBalances(decimal amountToDeposit)
    {
        //given
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        //var amountToDeposit = 100M;
        //when
        account.Deposit(amountToDeposit);
        //then
        Assert.Equal(amountToDeposit + openingBalance, account.GetBalance());
    }
}

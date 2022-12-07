using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests;

public class MakingDeposits
{
    [Theory]
    [InlineData(100)]
    [InlineData(50)]
    public void MakingDepositsIncreasesBalance(decimal amountToDeposit)
    {
        // Given
        var account = new BankAccount(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();

        // When
        account.Deposit(amountToDeposit);

        // Then
        Assert.Equal(amountToDeposit + openingBalance,
            account.GetBalance());


    }
}

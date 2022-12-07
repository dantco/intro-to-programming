

namespace Banking.UnitTests;

public class MakingWithdrawals
{

    [Theory]
    [InlineData(100)]
    [InlineData(50)]
    public void MakingWithdrawalsDecreasesBalance(decimal amountToWithdraw)
    {
        // Given
        var account = new BankAccount();
        var openingBalance = account.GetBalance();

        // When
        account.Withdraw(amountToWithdraw);

        // Then
        Assert.Equal(openingBalance - amountToWithdraw,
            account.GetBalance());
    }
}

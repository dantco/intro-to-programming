

using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests;

public class GoldAccountBenefits
{
    [Fact]
    public void GetBonusOnDeposit()
    {

        // Given
        var stubbedBonusCalculator = new Mock<ICalculateBonuses>();
        var account = new BankAccount(stubbedBonusCalculator.Object,
            new Mock<INotifyAccountReps>().Object);
        var openingBalance = account.GetBalance();
        var amountToDeposit = 92.42M;
        var expectedBonus = 42M;
        stubbedBonusCalculator.Setup(s => s.GetBonusForDepositOn(openingBalance, amountToDeposit)).Returns(expectedBonus);

        // When
        account.Deposit(amountToDeposit);

        // Then
        Assert.Equal(openingBalance + amountToDeposit + expectedBonus, 
            account.GetBalance());

    }
}


using Banking.Domain;

namespace Banking.UnitTests.BonusCalculation;

public class BonusesForBankAccountDeposits
{

    [Fact]
    public void AccountsWithProperBalanceGetBonus()
    {
        var bonusCalculator = new StandardBonusCalculator();

        decimal bonus = bonusCalculator.GetBonusForDepositOn(5000M, 100M);

        Assert.Equal(5M, bonus);
    }

    [Fact]
    public void AccountsWithoutProperBalanceGetNoBonus()
    {
        var bonusCalculator = new StandardBonusCalculator();

        decimal bonus = bonusCalculator.GetBonusForDepositOn(4999.99M, 100M);

        Assert.Equal(0M, bonus);
    }
}

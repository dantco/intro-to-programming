

namespace Banking.UnitTests.TestDoubles;

public class DummyBonusCalculator : ICalculateBonuses
{
    public decimal GetBonusForDepositOn(decimal currentBalance, decimal amountOfDeposit)
    {
        return 0;
    }
}

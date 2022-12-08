namespace Banking.Domain
{
    public class StandardBonusCalculator : ICalculateBonuses
    {
        // This is the "Single Point of Truth" for all bonus calculations.


        public decimal GetBonusForDepositOn(decimal currentBalance, decimal amountOfDeposit)
        {
            return currentBalance >= 5000 ? amountOfDeposit * .05M : 0;
        }
    }
}
namespace Banking.Domain;

public interface ICalculateBonuses
{
    decimal GetBonusForDepositOn(decimal currentBalance, decimal amountOfDeposit);
}
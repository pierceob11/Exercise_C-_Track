static class SavingsAccount
{
    
    public static float InterestRate(decimal balance)
    {
        float interestRate = balance switch
        {
                < 0m => 3.213f,
                < 1000m => 0.5f,
                < 5000m => 1.621f,
                >= 5000m => 2.475f
        };

        return interestRate;
    }

    public static decimal Interest(decimal balance)
    {
        decimal interestRate = (decimal)InterestRate(balance);
        decimal returnedInterest = balance * interestRate;
        decimal interestPercent = returnedInterest / 100;
        
        return interestPercent;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int newBalance;
        int years = 0;
        
        while(balance < targetBalance){
           balance = AnnualBalanceUpdate(balance);
            years++;
        }

        return years;
    }
}

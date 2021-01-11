namespace DownPaymentCalculator.Services
{
    public static class CalculationUtils
    {
        private const int TitleDeedHandlingCharge = 825;
        private const int MortgageBondHandlingCharge = 375;

        public static double calculateTitleDeed(int purchasePrice)
        {
            return (purchasePrice * 0.015) + TitleDeedHandlingCharge;
        }

        public static double calculateMortgageBondTax(int existingMortgageBond, int newMortgageBond)
        {
            return 0.02 * (newMortgageBond - existingMortgageBond) + 375;
        }

        public static double calculateCashContribution(int housePrice, double cashContributionPercentage)
        {
            return housePrice * cashContributionPercentage;
        }

        public static double convertCashContributionShareToPercentage(double cashContributionShare)
        {
            return cashContributionShare * 100;
        }
    }
}
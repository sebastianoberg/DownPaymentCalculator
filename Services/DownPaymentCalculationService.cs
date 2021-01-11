using System;
using DownPaymentCalculator.Contracts;
using DownPaymentCalculator.Services.Interfaces;

namespace DownPaymentCalculator.Services
{
    public class DownPaymentCalculationService : IDownPaymentCalculationService
    {
        public DownPaymentResponse CalculateTotalDownPayment(DownPaymentRequest request)
        {
            var percentageCashContributionShare = request.DownPaymentSummary.CashContributionShare / 100;
            var cashContribution = request.DownPaymentSummary.PurchasePrice * percentageCashContributionShare;
            var loanAmount = request.DownPaymentSummary.PurchasePrice - cashContribution;

            var mortgageBondCost = CalculationUtils.calculateMortgageBondTax(request.DownPaymentSummary.ExistingMortgageBond, Convert.ToInt32(loanAmount));
            var titleDeedCost = CalculationUtils.calculateTitleDeed(request.DownPaymentSummary.PurchasePrice);
            var totalDownPaymentNeeded = titleDeedCost + mortgageBondCost + cashContribution;

            return new DownPaymentResponse(mortgageBondCost, titleDeedCost, totalDownPaymentNeeded);
        }
    }
}
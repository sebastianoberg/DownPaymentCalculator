using System;
using DownPaymentCalculator.Contracts;
using DownPaymentCalculator.Services.Interfaces;

namespace DownPaymentCalculator.Services
{
    public class DownPaymentCalculationService : IDownPaymentCalculationService
    {
        public DownPaymentResponse CalculateTotalDownPayment(DownPaymentRequest request)
        {
            var newMortgageBond = request.DownPaymentSummary.PurchasePrice * 0.85;

            var mortgageBondCost = CalculationUtils.calculateMortgageBondTax(request.DownPaymentSummary.ExistingMortgageBond, Convert.ToInt32(newMortgageBond));
            var titleDeedCost = CalculationUtils.calculateTitleDeed(request.DownPaymentSummary.PurchasePrice);
            var totalDownPaymentNeeded = titleDeedCost + mortgageBondCost + request.DownPaymentSummary.CashContribution;

            return new DownPaymentResponse(mortgageBondCost, titleDeedCost, totalDownPaymentNeeded);
        }
    }
}
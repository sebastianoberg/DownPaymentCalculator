using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace DownPaymentCalculator.Contracts
{
    /// <summary>
    /// Request to calculate taxes and fees for down payment
    /// </summary>
    public class DownPaymentRequest
    {
        /// <summary>
        /// Down payment summary
        /// </summary>
        [Required]
        public DownPaymentSummary DownPaymentSummary { get; set; }
    }

    public class DownPaymentSummary
    {
        /// <summary>Initializes a new instance of the <see cref="DownPaymentSummary"/> class.</summary>
        public DownPaymentSummary()
        { }

        /// <summary>Initializes a new instance of the <see cref="DownPaymentSummary"/> class.</summary>
        /// <param name="existingMortgageBond">Existing mortgage bond</param>
        /// <param name="purchasePrice">House price</param>
        /// <param name="cashContributionShare">Cash contribution in percentage</param>
        [JsonConstructor]
        public DownPaymentSummary(
            int existingMortgageBond,
            int purchasePrice,
            double cashContributionShare
            )
        {
            ExistingMortgageBond = existingMortgageBond;
            PurchasePrice = purchasePrice;
            CashContributionShare = cashContributionShare;
        }

        /// <summary>
        /// Mortgage bond - Pantbrev
        /// </summary>
        public int ExistingMortgageBond { get; set; }

        /// <summary>
        /// Purchase price - Köpeskilling
        /// </summary>
        public int PurchasePrice { get; set; }

        /// <summary>
        /// Cash Contribution share in percentage - Kontantinsats
        /// </summary>
        public double CashContributionShare { get; set; }
    }
}
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
        /// <param name="existingMortgageBond">The street address.</param>
        /// <param name="purchasePrice">The zipcode.</param>
        [JsonConstructor]
        public DownPaymentSummary(
            int existingMortgageBond,
            int purchasePrice
            )
        {
            ExistingMortgageBond = existingMortgageBond;
            PurchasePrice = purchasePrice;
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
        /// -----
        /// </summary>
        public int City { get; set; }
    }
}
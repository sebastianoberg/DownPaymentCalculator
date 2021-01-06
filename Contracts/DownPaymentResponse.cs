using Newtonsoft.Json;

namespace DownPaymentCalculator.Contracts
{
    /// <summary>
    /// Reponse including taxes and fees for down payment
    /// </summary>
    public class DownPaymentResponse
    {
        /// <summary>Initializes a new instance of the <see cref="DownPaymentResponse"/> class.</summary>
        public DownPaymentResponse()
        { }

        /// <summary>Initializes a new instance of the <see cref="DownPaymentResponse"/> class.</summary>
        /// <param name="mortgageBondCost">Total cost of the mortgage tax</param>
        /// <param name="titleDeedCost">Total cost of the title deed tax</param>
        /// <param name="totalDownPaymentNeeded">Total amount of money needed to buy the house. Mortgage bond tax + title deed cost + cash contribution</param>
        [JsonConstructor]
        public DownPaymentResponse(
            double mortgageBondCost,
            double titleDeedCost,
            double totalDownPaymentNeeded
            )
        {
            MortgageBondCost = mortgageBondCost;
            TitleDeedCost = titleDeedCost;
            TotalDownPaymentNeeded = totalDownPaymentNeeded;
        }

        /// <summary>
        /// Total mortgage bond cost - Total skattekostnad för nya pantbrev
        /// </summary>
        public double MortgageBondCost { get; set; }

        /// <summary>
        /// Total title deed cost - Total skattekostnad för lagfart
        /// </summary>
        public double TitleDeedCost { get; set; }

        /// <summary>
        /// Total down payment needed - Total kontantinsats inkl skatter som behövs för att köpa huset. Kostnad för pantbrev + lagfart + kontantinsats
        /// </summary>
        public double TotalDownPaymentNeeded { get; set; }
    }
}
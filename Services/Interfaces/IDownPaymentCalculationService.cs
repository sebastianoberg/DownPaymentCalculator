using System.Threading.Tasks;
using DownPaymentCalculator.Contracts;

namespace DownPaymentCalculator.Services.Interfaces
{
    public interface IDownPaymentCalculationService
    {
        DownPaymentResponse CalculateTotalDownPayment(DownPaymentRequest request);
    }
}
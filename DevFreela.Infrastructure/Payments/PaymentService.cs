using DevFreela.Core.DTOs;
using DevFreela.Core.Services;
using System.Text;
using System.Text.Json;

namespace DevFreela.Infrastructure.Payments
{
    public class PaymentService : IPaymentService
    {
        public readonly IMessageBusService _messageBusService;
        private const string QueueName = "Payments";

        public PaymentService(IMessageBusService messageBusService)
        {
            _messageBusService = messageBusService;
        }

        public void ProcessPayment(PaymentInfoDTO paymentInfoDTO)
        {
            var paymentsInfoJson = JsonSerializer.Serialize(paymentInfoDTO);

            var paymentInfoBytes = Encoding.UTF8.GetBytes(paymentsInfoJson);

            _messageBusService.Publish(QueueName, paymentInfoBytes);
        }
    }
}

using Models.Domain;
using Stripe;

namespace Service.Contracts
{
    public interface IStripePaymentService
    {
        Charge Charge(StripePaymentRequest stripePaymentRequest);
    }
}
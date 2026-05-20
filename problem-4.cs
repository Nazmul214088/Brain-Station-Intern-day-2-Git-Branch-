using System;

namespace FareEngineAssessment
{
    public enum TripStatus
    {
        Pending,
        Paid,
        Failed
    }

    // Payment Interface
    public interface IPaymentService
    {
        bool ProcessPayment(
            string passengerId,
            decimal amount);
    }

    // Mock Payment Service
    public class CreditCardPaymentService
        : IPaymentService
    {
        public bool ProcessPayment(
            string passengerId,
            decimal amount)
        {
            Console.WriteLine(
                $"Payment of {amount} processed for Passenger ID: {passengerId}");

            return true;
        }
    }

    // Trip Completion
    public class TripPayment
    {
        public TripStatus Status { get; private set; }

        public void CompleteTrip(
            IPaymentService paymentService,
            string passengerId,
            decimal amount)
        {
            bool success =
                paymentService.ProcessPayment(
                    passengerId,
                    amount);

            Status =
                success
                ? TripStatus.Paid
                : TripStatus.Failed;
        }
    }
}

using System;

namespace FareEngineAssessment
{
    // Promotion Interface
    public interface IPromotion
    {
        decimal ApplyDiscount(decimal currentFare);
    }

    // Percentage Discount
    public class PercentageDiscount : IPromotion
    {
        private decimal Percentage { get; set; }

        public PercentageDiscount(decimal percentage)
        {
            Percentage = percentage;
        }

        public decimal ApplyDiscount(decimal currentFare)
        {
            decimal discount =
                currentFare * (Percentage / 100);

            return currentFare - discount;
        }
    }

    // Flat Discount
    public class FlatDiscount : IPromotion
    {
        private decimal DiscountAmount { get; set; }

        public FlatDiscount(decimal amount)
        {
            DiscountAmount = amount;
        }

        public decimal ApplyDiscount(decimal currentFare)
        {
            return currentFare - DiscountAmount;
        }
    }
}

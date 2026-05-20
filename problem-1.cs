using System;

namespace FareEngineAssessment
{
    // Abstract Base Class
    public abstract class Vehicle
    {
        public string LicensePlate { get; private set; }

        public decimal BaseFare { get; protected set; }

        protected Vehicle(string licensePlate, decimal baseFare)
        {
            LicensePlate = licensePlate;
            BaseFare = baseFare;
        }

        public abstract decimal PerKmRate { get; }

        public abstract decimal PerMinuteRate { get; }

        public virtual decimal CalculateFare(
            double distanceKm,
            int durationMinutes)
        {
            decimal distanceCost =
                (decimal)distanceKm * PerKmRate;

            decimal timeCost =
                durationMinutes * PerMinuteRate;

            return BaseFare + distanceCost + timeCost;
        }
    }

    // Standard Car
    public class StandardCar : Vehicle
    {
        public StandardCar(string licensePlate)
            : base(licensePlate, 50m)
        {
        }

        public override decimal PerKmRate => 12m;

        public override decimal PerMinuteRate => 2m;
    }

    // Luxury Sedan
    public class LuxurySedan : Vehicle
    {
        private decimal LuxuryTax { get; set; }

        public LuxurySedan(string licensePlate)
            : base(licensePlate, 100m)
        {
            LuxuryTax = 200m;
        }

        public override decimal PerKmRate => 25m;

        public override decimal PerMinuteRate => 5m;

        public override decimal CalculateFare(
            double distanceKm,
            int durationMinutes)
        {
            decimal normalFare =
                base.CalculateFare(distanceKm, durationMinutes);

            return normalFare + LuxuryTax;
        }
    }
}

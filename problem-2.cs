using System;

namespace FareEngineAssessment
{
    public class Passenger
    {
        public string PassengerId { get; set; }
        public string Name { get; set; }

        public Passenger(string passengerId, string name)
        {
            PassengerId = passengerId;
            Name = name;
        }
    }

    public class Trip
    {
        public Vehicle Vehicle { get; private set; }

        public Passenger Passenger { get; private set; }

        public double DistanceKms { get; private set; }

        public int DurationMinutes { get; private set; }

        public Trip(
            Vehicle vehicle,
            Passenger passenger,
            double distanceKms,
            int durationMinutes)
        {
            Vehicle = vehicle;
            Passenger = passenger;
            DistanceKms = distanceKms;
            DurationMinutes = durationMinutes;
        }

        public decimal CalculateFinalFare()
        {
            decimal fare =
                Vehicle.CalculateFare(
                    DistanceKms,
                    DurationMinutes);

            // Fare cannot go below BaseFare
            if (fare < Vehicle.BaseFare)
            {
                fare = Vehicle.BaseFare;
            }

            return fare;
        }
    }
}

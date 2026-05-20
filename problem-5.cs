using System;

namespace FareEngineAssessment
{
    // Custom Exception
    public class InvalidTripException : Exception
    {
        public InvalidTripException(string message)
            : base(message)
        {
        }
    }

    public class TripValidation
    {
        public static void ValidateTrip(
            Vehicle vehicle,
            double distanceKms,
            int durationMinutes)
        {
            if (vehicle == null)
            {
                throw new InvalidOperationException(
                    "No vehicle assigned.");
            }

            if (distanceKms < 0)
            {
                throw new InvalidTripException(
                    "Distance cannot be negative.");
            }

            if (durationMinutes <= 0)
            {
                throw new InvalidTripException(
                    "Duration must be greater than zero.");
            }
        }
    }
}

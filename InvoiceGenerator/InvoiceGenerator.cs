using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
   
        public class InvoiceGenerator
        {
            private static readonly double COST_PER_KILOMETER = 10.0;
            private static readonly double COST_PER_MINUTE = 1.0;
            private static readonly double MINIMUM_FARE = 5.0;
            private double cabFare = 0.0;

            //UC1 - Calculate Fare 
            public double CalculatFare(double distance, double time)
            {
                this.cabFare = (distance * COST_PER_KILOMETER) + (time * COST_PER_MINUTE);
                return Math.Max(this.cabFare, MINIMUM_FARE);
            }
        //UC2 - Multiple Rides
        public double GetMultipleRideFare(Ride[] rides)
        {
            double totalRideFare = 0.0;
            foreach (Ride ride in rides)
            {
                totalRideFare += this.CalculatFare(ride.rideDistance, ride.rideTime);
            }
            return totalRideFare;
        }
        //UC3 - Enhanced Invoice
        public InvoiceSummary GetAverageFare(Ride[] rides)
        {
            double totalRideFare = 0.0;
            foreach (Ride ride in rides)
            {
                totalRideFare += this.CalculatFare(ride.rideDistance, ride.rideTime);
            }
            return new InvoiceSummary(totalRideFare, rides.Length);
        }
    }
    }
       


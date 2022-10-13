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
        }
    }
       


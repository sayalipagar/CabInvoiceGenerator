namespace CabInvoiceGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC1
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();  
            double fare = invoiceGenerator.CalculatFare(2.0, 4.0);
            Console.WriteLine("The Total Fare For The Journey : " + fare);

            //UC2
            Ride[] ride = { new Ride(1, 2), new Ride(3, 4) };                               
            double getMultiple = invoiceGenerator.GetMultipleRideFare(ride);
            Console.WriteLine("\nThe Aggregate Total For All : " + getMultiple);

            //UC3
            Ride[] ridedata = { new Ride(1, 2), new Ride(3, 4) };                                   
            InvoiceSummary data = invoiceGenerator.GetAverageFare(ridedata);
            Console.WriteLine("\nThe Average Fare : " + data.averageFare + "\nThe Total Number Of Rides: " + data.noOfRides);
        }
    }
}
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
            Ride[] ride = { new Ride(1, 2), new Ride(3, 4) };                               //UC2
            double getMultiple = invoiceGenerator.GetMultipleRideFare(ride);
            Console.WriteLine("\nThe Aggregate Total For All : " + getMultiple);
        }
    }
}
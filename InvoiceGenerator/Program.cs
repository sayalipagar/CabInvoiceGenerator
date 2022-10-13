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
        }
    }
}
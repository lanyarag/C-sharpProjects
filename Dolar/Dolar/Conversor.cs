
namespace Dolar
{
    public class Conversor
    {
        double ValueDollar;
        double IOF = 0.06;

        public void Exchange()
        {
            Console.WriteLine("How much is the dollar today?");
            ValueDollar = double.Parse(Console.ReadLine());
            Console.WriteLine("What was the purchase price (in dollar)?");
            double ValuePurchase = double.Parse(Console.ReadLine());
            double ValueReais = ValuePurchase * ValueDollar;
            ValueReais = ValueReais + (ValueReais * IOF);
            Console.WriteLine($"The purchase price in reais is {ValueReais}");
        }
    }
}

namespace Klasser_uppgift_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bil bil1 = new bil();
            bil1.MataIn();
            bil1.MataUt();

            bil bil2 = new bil();
            bil2.MataIn();
            bil2.MataUt();

            Console.ReadKey();
        }
    }
}
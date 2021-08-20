using System;

namespace StockProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Stock Problem");
            Stock stock = new Stock();
            Console.WriteLine("give the number of stocks");
            int NumOfStocks = int.Parse(Console.ReadLine());
            for (int i = 1; i <= NumOfStocks; i++)
            {
                Console.WriteLine("give the sharename");
                string ShareName = Console.ReadLine();
                Console.WriteLine("give the number of shares");
                int NoOfShares = int.Parse(Console.ReadLine());
                Console.WriteLine("give the price per each share");
                int PricePerEachShare = int.Parse(Console.ReadLine());
                stock.Stockvalue(NoOfShares, PricePerEachShare, ShareName);
            }
        }
    }
}

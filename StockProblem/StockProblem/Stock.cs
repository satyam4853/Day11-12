using System;
using System.Collections.Generic;
using System.Text;

namespace StockProblem
{
    class Stock
    {
        public int totalshare = 0;
        public int totalvalue = 0;
        public void Stockvalue(int a, int b, string c)
        {
            int stockvalue = a * b;
            Console.WriteLine("the value of the stock for" + c + " shares is :  " + stockvalue);
            totalvalue += (a * b);
            Console.WriteLine("the total value of the stock is  " + totalvalue);


        }
    }
}

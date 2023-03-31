using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent_Examples
{
    class Stock
    {
        public string Symbol { get; set; }
        public double Price { get; set; }
        public double RiskLevel { get; set; }

        public Stock(string symbol, double price, double riskLevel)
        {
            Symbol = symbol;
            Price = price;
            RiskLevel = riskLevel;
        }
    }

    class UtilityBasedAgent
    {
        static List<Stock> stocks = new List<Stock>();

        public void DoStonks()
        {
            // Initialize the stocks
            stocks.Add(new Stock("AAPL", 200.0, 0.1));
            stocks.Add(new Stock("GOOG", 150.0, 0.2));
            stocks.Add(new Stock("MSFT", 100.0, 0.3));

            while (true)
            {
                Stock bestStock = GetBestStock();
                double utility = EstimateUtility(bestStock);
                if (utility > 0)
                {
                    Console.WriteLine("Buying stock: " + bestStock.Symbol);
                }
                else
                {
                    Console.WriteLine("Selling stock: " + bestStock.Symbol);
                }
            }

            Console.WriteLine("\n\nTest 4 Done.");
            Console.ReadKey();
        }

        static Stock GetBestStock()
        {
            // Code to select the stock with the highest estimated utility
            Stock bestStock = null;
            double bestUtility = double.MinValue;
            foreach (Stock stock in stocks)
            {
                double utility = EstimateUtility(stock);
                if (utility > bestUtility)
                {
                    bestStock = stock;
                    bestUtility = utility;
                }
            }

            return bestStock;
        }

        static double EstimateUtility(Stock stock)
        {
            // Code to estimate the utility of a stock
            // For this example, we'll use a simple formula based on the price and risk level
            return stock.Price - stock.RiskLevel * 100;
        }
    }
}

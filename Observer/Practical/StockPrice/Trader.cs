
namespace StockPrice
{
    // concrete observer
    public class Trader : ITrader
    {
        private readonly string _name;

        public Trader(string name)
        {
            _name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine($"Notifying {_name} of {stock.Symbol}'s price change to {stock.Price}");
        }
    }
}

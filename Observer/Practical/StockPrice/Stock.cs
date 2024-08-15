namespace StockPrice
{
    public class Stock : IStockTicker
    {
        private List<ITrader> _traders = new List<ITrader>();
        public string Symbol { get; private set; }

        private double _price;

        public Stock(string symbol, double price)
        {
            Symbol = symbol;
            _price = price;
        }

        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }

            }
        }


        public void Notify()
        {
            foreach (var trader in _traders)
            {
                trader.Update(this);
            }
        }

        public void RegisterTrader(ITrader trader)
        {
            _traders.Add(trader);
        }

        public void UnregisterTrader(ITrader trader)
        {
            _traders.Remove(trader);
        }
    }
}

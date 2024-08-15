namespace StockPrice
{
    // subject interface
    public interface IStockTicker
    {
        void RegisterTrader(ITrader trader);
        void UnregisterTrader(ITrader trader);
        void Notify();

    }
}

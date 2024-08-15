namespace StockPrice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stock HSBLStock = new Stock("HSBL", 150.00);

            Trader Alvin = new Trader("Alvin");
            Trader Alysa = new Trader("Alysa");
            Trader Alexa = new Trader("Alexa");


            // register traders
            HSBLStock.RegisterTrader(Alvin);
            HSBLStock.RegisterTrader(Alysa);
            HSBLStock.RegisterTrader(Alexa);


            // unregister trader
            HSBLStock.UnregisterTrader(Alexa);


            // simulate a price change
            HSBLStock.Price = 200.00;


            Console.ReadKey();

        }
    }
}
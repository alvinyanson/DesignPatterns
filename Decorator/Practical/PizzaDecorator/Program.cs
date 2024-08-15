namespace PizzaDecorator
{
    class Program
    {
        public static void Main(string[] args)
        {
            PlainPizza plainPizza = new PlainPizza();
            Console.WriteLine(plainPizza.MakePizza());

            PizzaDecorator chickenPizzaDecorator = new ChickenPizzaDecorator(plainPizza);
            Console.WriteLine($"{chickenPizzaDecorator.MakePizza()}");

            PizzaDecorator vegetablePizzaDecorator = new VegPizzaDecorator(plainPizza);
            Console.WriteLine($"{vegetablePizzaDecorator.MakePizza()}");

            Console.Read();
        }
    }

}
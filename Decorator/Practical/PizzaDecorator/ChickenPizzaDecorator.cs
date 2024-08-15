
namespace PizzaDecorator
{
    public class ChickenPizzaDecorator : PizzaDecorator
    {
        public ChickenPizzaDecorator(IPizza pizza) : base (pizza)
        {
            
        }

        public override string MakePizza()
        {
            return pizza.MakePizza() + AddChimken();
        }

        private string AddChimken()
        {
            return ", Chimken added! 🍗";
        }
    }
}

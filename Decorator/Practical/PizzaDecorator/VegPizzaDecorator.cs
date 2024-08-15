
namespace PizzaDecorator
{
    public class VegPizzaDecorator : PizzaDecorator
    {
        public VegPizzaDecorator(IPizza pizza) : base (pizza)
        {
            
        }

        public override string MakePizza()
        {
            return pizza.MakePizza() + AddVegetables();
        }

        private string AddVegetables()
        {
            return ", Vegetables added 🥕";
        }
    }
}

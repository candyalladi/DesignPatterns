namespace FactoryPattern
{
    public class NYStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    pizza.type = "Cheese";
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza();
                    pizza.type = "Pepperoni";
                    break;
                case "clam":
                    pizza = new CalmPizza();
                    pizza.type = "Calm";
                    break;
                case "veggie":
                    pizza = new VeggiePizza();
                    pizza.type = "Veggie";
                    break;
                default:
                    break;
            }
            return pizza;
        }
    }
}

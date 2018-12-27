namespace FactoryPattern
{
    public abstract class PizzaStore
    {
        SimplePizzaFactory pizzaFactory;

        public PizzaStore()
        {

        }

        public PizzaStore(SimplePizzaFactory pizzaFactory)
        {
            this.pizzaFactory = pizzaFactory;
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        public abstract Pizza CreatePizza(string type);
    }
}

using System;

namespace FactoryPattern
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
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

    internal class VeggiePizza : Pizza
    {
    }

    internal class CalmPizza : Pizza
    {
    }

    internal class PepperoniPizza : Pizza
    {
    }

    internal class CheesePizza : Pizza
    {
    }

    public abstract class Pizza
    {
        public string type;

        internal void Prepare()
        {
            Console.WriteLine($"Preparing the dough to make {type} Pizza!");
        }

        internal void Bake()
        {
            Console.WriteLine($"Baking the base to make {type} Pizza!");
        }

        internal void Cut()
        {
            Console.WriteLine($"Cutting the Base to make {type} Pizza!");
        }

        internal void Box()
        {
            Console.WriteLine($"Boxing the {type} Pizza!");
        }
    }
}

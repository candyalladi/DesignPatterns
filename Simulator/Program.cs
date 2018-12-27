using CommandPattern;
using CompoundPattern;
using DesignPatterns;
using FactoryPattern;
using IteratorPattern;
using ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplatePattern;

namespace Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strategy Pattern

            //MallardDuck mallardDuck = new MallardDuck();
            //mallardDuck.PerformFly(new FlywithWings());
            //mallardDuck.PerformQuak(new Quack());
            //mallardDuck.Display();

            //RoboDuck roboDuck = new RoboDuck();
            //roboDuck.PerformFly(new FlyNoWay());
            //roboDuck.PerformQuak(new Squeak());
            //roboDuck.Display();

            //Observer Pattern
            //WeatherData weatherData = new WeatherData();
            //CurrentConditionsDisplay currentConditions = new CurrentConditionsDisplay(weatherData);

            //weatherData.setMeasurements(80, 65, 30.4f);
            //weatherData.setMeasurements(82, 72, 40.4f);
            //weatherData.setMeasurements(90, 55, 20.4f);

            //Factory Pattern
            //PizzaStore pizzaStore = new NYStylePizzaStore();
            //pizzaStore.OrderPizza("cheese");

            //pizzaStore = new ChicagoStylePizzaStore();
            //pizzaStore.OrderPizza("pepperoni");

            //Command Pattern
            //SimpleRemoteControl simpleRemoteControl = new SimpleRemoteControl();
            //RemoteControl remoteControl = new RemoteControl();

            //Light light = new Light();
            //LightOnCommand lightOnCommand = new LightOnCommand(light);
            //LightOffCommand lightOffCommand = new LightOffCommand(light);

            //GarageDoor garage = new GarageDoor();
            //GarageDoorOpenCommand garageDoorOpenCommand = new GarageDoorOpenCommand(garage);
            //GarageDoorCloseCommand garageDoorCloseCommand = new GarageDoorCloseCommand(garage);


            //remoteControl.SetCommand(0,lightOnCommand,lightOffCommand);
            //remoteControl.OnButtonWasPressed(0);

            //remoteControl.SetCommand(1,garageDoorOpenCommand,garageDoorCloseCommand);
            //remoteControl.OnButtonWasPressed(1);

            //remoteControl.OffButtonWasPressed(0);
            //remoteControl.OffButtonWasPressed(1);

            //Adapter Pattern

            //Duck mallardDuck = new MallardDuck();

            //ITurkey turkey = new WildTurkey();
            //Duck turkeyAdapter = new TurkeyAdapter(turkey);

            //turkey.Globble();
            //turkey.Fly();

            //TestDuck(mallardDuck);
            //TestDuck(turkeyAdapter);

            //Template Pattern
            //CaffeineBeverage coffee = new Coffee();
            //coffee.PrepareRecipe();

            //CaffeineBeverage tea = new Tea();
            //tea.PrepareRecipe();

            //Iterator Pattern
            //DinnerMenu dinnerMenu = new DinnerMenu();
            //IIterator iterator = dinnerMenu.CreateIterator();
            //Console.WriteLine(iterator);
            //while(iterator.hasNext())
            //{
            //    MenuItem item = (MenuItem)iterator.next();
            //    Console.WriteLine($"{item.getName()} , {item.getDescription()}, {item.getPrice()}");               
            //}

            //Compound Pattern
            AbstractDuckFactory countDuckFactory = new CountingDuckFactory();
            Simulate(countDuckFactory);

            Console.ReadKey();
        }

        static void TestDuck(Duck duck)
        {
            duck.PerformQuak(new Quack());
            duck.PerformFly(new FlywithWings());
        }

        private static void Simulate(AbstractDuckFactory abstractDuckFactory)
        {
            IQuakable mallardDuck = abstractDuckFactory.CreateMallardDuck();// new QuackCounter(new CompoundPattern.MallardDuck());
            IQuakable redheadDuck = abstractDuckFactory.CreateRedhedDuck();// new QuackCounter(new RedheadDuck());
            IQuakable duckCalls = abstractDuckFactory.CreateDuckCalls();// new QuackCounter(new DuckCalls());
            IQuakable rubberDuck = abstractDuckFactory.CreateRubberDuck();// new QuackCounter(new RubberDuck());
            IQuakable gooseAdapter = new GooseAdapter(new Goose());

            Console.WriteLine("Duck Simulator - Composite Flocks");

            Flock flockOfDucks = new Flock();
            flockOfDucks.Add(mallardDuck);
            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCalls);
            flockOfDucks.Add(rubberDuck);            

            Flock flockOfMallardDucks = new Flock();
            flockOfDucks.Add(abstractDuckFactory.CreateMallardDuck());
            flockOfDucks.Add(abstractDuckFactory.CreateMallardDuck());
            flockOfDucks.Add(abstractDuckFactory.CreateMallardDuck());
            flockOfDucks.Add(abstractDuckFactory.CreateMallardDuck());

            flockOfDucks.Add(flockOfMallardDucks);

            Console.WriteLine("Duck simulator whole flock simulator");
            Simulate(flockOfDucks);

            Console.WriteLine("Duck simulator MallardDuck flock simulator");
            Simulate(flockOfMallardDucks);
            //Simulate(redheadDuck);
            //Simulate(duckCalls);
            //Simulate(rubberDuck);
            //Simulate(gooseAdapter);

            Console.Write($"The ducks quacked {QuackCounter.GetQuackCount()} times!");
        }

        private static void Simulate(IQuakable quakable)
        {
            quakable.Quack();
        }
    }
}

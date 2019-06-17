using System;
using Design_Pattern_Code.DuckExample;
using Design_Pattern_Code.Pizza_Store___Factory;
using Design_Pattern_Code.Starbuzz_Coffe___Decorator_Pattern;
using Design_Pattern_Code.Starbuzz_Coffe___Decorator_Pattern.Beverages;
using Design_Pattern_Code.Starbuzz_Coffe___Decorator_Pattern.Condiments;
using Design_Pattern_Code.WeatherForecast___Observer_Pattern;
using Design_Pattern_Code.Chocolate_Factory___Singleton;
using Design_Pattern_Code.Remote_Control___Command_Pattern;
using Design_Pattern_Code.Remote_Control___Command_Pattern.Commands;
using Design_Pattern_Code.Remote_Control___Command_Pattern.Devices;
using Design_Pattern_Code.Ducks_2___Adapter_Pattern;

namespace Design_Pattern_Code
{
    class Program
    {
        static void Main()
        {
            //DuckExample Code - Stratergy Pattern
            //Duck modelDuck = new ModelDuck();
            //modelDuck.SetFlyBehavior(new FlyRocketPowered());
            //modelDuck.SetQuackBehavior(new Quack());
            //modelDuck.Fly();
            //modelDuck.Quack();

            //WeatherForecast - ObserverPattern
            //WeatherData wd = new WeatherData();
            //CurrentConditionsDisplay current = new CurrentConditionsDisplay(wd);
            //ForcastDisplay forcast = new ForcastDisplay(wd);

            //wd.SetMeasurements(80, 56, 17.1f);
            //wd.SetMeasurements(74, 50, 29.7f);
            //wd.SetMeasurements(69, 41, 9.1f);

            //Starbuzz code - Decorator Pattern
            //var bev = new Espresso();
            //Console.WriteLine(bev.GetDescription() + " £" + bev.Cost()); //This works

            //var bev2 = new Mocha(new Whip(new DarkRoast()));//Two mochas?
            //Console.WriteLine(bev2.GetDescription() + " £" + bev2.Cost()); // When we use the wrappers, it outputs wrong description. but cost is correct
            //var bev3 = new Soy(new Mocha(new Whip(new HouseBlend())));
            //Console.WriteLine(bev3.GetDescription() + " £" + bev3.Cost());

            //Pizza - Factory
            //PizzaStore nyPizzaStore = new NYPizzaStore();
            //PizzaStore chPizzaStore = new ChicagoPizzaStore();

            //var nypizza = nyPizzaStore.OrderPizza("cheese");
            //Console.WriteLine("Pizza ordered: " + nypizza.GetName());

            //var nypizzaVeg = nyPizzaStore.OrderPizza("veggie");
            //Console.WriteLine("Pizza ordered: " + nypizzaVeg.GetName());

            //var chpizza = chPizzaStore.OrderPizza("cheese");
            //Console.WriteLine("Pizza ordered: " + chpizza.GetName()); 

            //Chocolate Factory - Singleton
            //ChocolateBoiler.GetInstance().Boil();
            //ChocolateBoiler.GetInstance().Drain(); 

            //Remote Control - Command Pattern
            //RemoteControl remote = new RemoteControl();

            //Light light = new Light("Kitchen");
            //Stereo stereo = new Stereo();

            //remote.SetCommand(0, new LightOnCommand(light), new LightOffCommand(light));
            //remote.SetCommand(1, new StereoOnCommand(stereo), new StereoOffCommand(stereo));
            //remote.onButtonPushed(0);
            //remote.onButtonPushed(0);
            //remote.Undo();

            //remote.offButtonPushed(0);

            //remote.onButtonPushed(1);
            //remote.onButtonPushed(1);
            //remote.Undo();
            //remote.offButtonPushed(1);

            //Console.WriteLine(remote.ToString());
            IDuck adapterDuck = new TurkeyAdapter(new WildTurkey());
            adapterDuck.Quack();
            adapterDuck.Fly();
        }
    }
}

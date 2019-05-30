using Design_Pattern_Code.Pizza_Store___Factory.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Pizza_Store___Factory
{
    public class ClamPizza : Pizza
    {
        IPizzaIncredientFactory incredientFactory;

        public ClamPizza(IPizzaIncredientFactory incredientFactory)
        {
            this.incredientFactory = incredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = incredientFactory.createDough();
            sauce = incredientFactory.createSauce();
            cheese = incredientFactory.createCheese();
            clams = incredientFactory.createClams();
        }
    }
}

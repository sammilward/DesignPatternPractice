using Design_Pattern_Code.Pizza_Store___Factory.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Pizza_Store___Factory
{
    public class CheesePizza : Pizza
    {
        IPizzaIncredientFactory incredientFactory;

        public CheesePizza(IPizzaIncredientFactory incredientFactory)
        {
            this.incredientFactory = incredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = incredientFactory.createDough();
            sauce = incredientFactory.createSauce();
            cheese = incredientFactory.createCheese();
        }
    }
}

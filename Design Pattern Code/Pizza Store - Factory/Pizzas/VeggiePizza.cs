using Design_Pattern_Code.Pizza_Store___Factory.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Pizza_Store___Factory
{
    public class VeggiePizza : Pizza
    {
        IPizzaIncredientFactory incredientFactory;

        public VeggiePizza(IPizzaIncredientFactory incredientFactory)
        {
            this.incredientFactory = incredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = incredientFactory.createDough();
            sauce = incredientFactory.createSauce();
            cheese = incredientFactory.createCheese();
            veggies = incredientFactory.createVeggies();
        }
    }
}

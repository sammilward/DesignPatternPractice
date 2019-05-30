using Design_Pattern_Code.Pizza_Store___Factory.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Pizza_Store___Factory
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIncredientFactory incredientFactory = new NYPizzaIncredientFactory();

            if(type.Equals("cheese"))
            {
                pizza = new CheesePizza(incredientFactory);
                pizza.SetName("New York Styled Cheese Pizza");
            }
            else if(type.Equals("veggie"))
            {
                pizza = new VeggiePizza(incredientFactory);
                pizza.SetName("New York Styled Veggie Pizza");
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza(incredientFactory);
                pizza.SetName("New York Styled Clam Pizza");
            }
            return pizza;
        }
    }
}

using Design_Pattern_Code.Pizza_Store___Factory.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Pizza_Store___Factory
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIncredientFactory incredientFactory = new ChicagoPizzaIncredientFactory();

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(incredientFactory);
                pizza.SetName("Chicago Styled Cheese Pizza");
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza(incredientFactory);
                pizza.SetName("Chicago Styled Veggie Pizza");
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza(incredientFactory);
                pizza.SetName("Chicago Styled Clam Pizza");
            }
            return pizza;
        }
    }
}

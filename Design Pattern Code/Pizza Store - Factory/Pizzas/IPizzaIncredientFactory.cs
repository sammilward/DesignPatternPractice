using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Pizza_Store___Factory.Pizzas
{
    public interface IPizzaIncredientFactory
    {
        IDough createDough();
        ISauce createSauce();
        ICheese createCheese();
        List<IVeggies> createVeggies();
        IPepperoni createPepperoni();
        IClams createClams();
    }
}

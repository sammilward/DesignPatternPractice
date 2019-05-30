    using Design_Pattern_Code.Pizza_Store___Factory.Incredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Pizza_Store___Factory.Pizzas
{
    public class NYPizzaIncredientFactory : IPizzaIncredientFactory
    {
        public ICheese createCheese()
        {
            return new ReggianoCheese();
        }

        public IClams createClams()
        {
            return new FreshClams();
        }

        public IDough createDough()
        {
            return new ThinCrustDough();
        }

        public IPepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce createSauce()
        {
            return new MarinaraSauce();
        }

        public List<IVeggies> createVeggies()
        {
            return new List<IVeggies> { new Garlic(), new Onion(), new Mushrooms(), new RedPepper() };
        }
    }
}

using Design_Pattern_Code.Pizza_Store___Factory.Incredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.Pizza_Store___Factory.Pizzas
{
    public class ChicagoPizzaIncredientFactory : IPizzaIncredientFactory
    {
        public ICheese createCheese()
        {
            return new MozzarelaCheese();
        }

        public IClams createClams()
        {
            return new FrozenClams();
        }

        public IDough createDough()
        {
            return new ThickCrustDough();
        }

        public IPepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce createSauce()
        {
            return new PlumTomatoSauce();
        }

        public List<IVeggies> createVeggies()
        {
            return new List<IVeggies> { new Spinach(), new BlackOlives(), new EggPlant() };
        }
    }
}

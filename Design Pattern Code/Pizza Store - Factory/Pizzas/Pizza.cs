using Design_Pattern_Code.Pizza_Store___Factory.Pizzas;
using System;
using System.Collections.Generic;

namespace Design_Pattern_Code.Pizza_Store___Factory
{
    public abstract class Pizza
    {
        protected string name;

        public IDough dough;
        public ISauce sauce;
        public ICheese cheese;
        public IPepperoni pepperoni;
        public IClams clams;
        public List<IVeggies> veggies = new List<IVeggies>();

        public abstract void Prepare();

        public void Box()
        {
            System.Console.WriteLine("Boxing Pizza...");
        }

        public virtual void Cut()
        {
            System.Console.WriteLine("Cutting Pizza...");
        }

        public void Bake()
        {
            System.Console.WriteLine("Baking Pizza...");
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
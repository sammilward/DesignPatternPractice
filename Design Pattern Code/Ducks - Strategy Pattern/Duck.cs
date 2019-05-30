using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code.DuckExample
{
    public abstract class Duck
    {
        protected IFlyable flyBehavior;
        protected IQuackable quackBehavior;

        public void SetFlyBehavior(IFlyable behavior)
        {
            flyBehavior = behavior;
        }

        public void SetQuackBehavior(IQuackable behavior)
        {
            quackBehavior = behavior;
        }

        public abstract void Display();

        public void Fly()
        {
            flyBehavior.Fly();
        }

        public void Quack()
        {
            quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("I am swimming");
        }
    }
}

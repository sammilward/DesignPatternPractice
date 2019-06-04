using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Design_Pattern_Code.Chocolate_Factory___Singleton
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        private static ChocolateBoiler uniqueChocolateBoiler;

        //private static ChocolateBoiler uniqueChocolateBoiler = new ChocolateBoiler();
        //We could use EAGER INSTITATION. Good if your program will ALWAYS need this object. 
        //Gaurentees the instance will be created before threads can use GetInstance()

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        [MethodImpl(MethodImplOptions.Synchronized)] //This is equal to the Java keyword Syncronize. This means that this method will not be 
                                                     //accessed by a thread until the other thread has finished with the method. This will impact performance heavily.
                                                     //Can decrease performance by factor of 100.
        public static ChocolateBoiler GetInstance()
        {
            if (uniqueChocolateBoiler == null)
            {
                uniqueChocolateBoiler = new ChocolateBoiler();
            }
            return uniqueChocolateBoiler;
        }

        //If performance is an issue with the singleton in your application this could be the issues. 
        //Using the DOUBLE CHECKED LOCKING we get the benefits of syncronization whilst lowering the costs.
        //We only syncronize the FIRST time we initialise the singleton. Meaning performance is greatly improved.
        //public static ChocolateBoiler GetInstance()
        //{
        //    if (uniqueChocolateBoiler == null)
        //    {
        //        syncronized(Singleton.class) {
        //            if (uniqueChocolateBoiler == null) {
        //                 uniqueChocolateBoiler = new ChocolateBoiler();
        //            }
        //        }
        //    }
        //    return uniqueChocolateBoiler;
        //}

        public void Fill()
        {
            if (IsEmpty())
            {
                empty = false;
                boiled = false;
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                empty = true;
            }
        }

        public void Boil()
        {
            if(!IsEmpty() && !IsBoiled())
            {
                boiled = true;
            }
        }

        private bool IsBoiled()
        {
            return boiled;
        }

        private bool IsEmpty()
        {
            return empty;
        }
    }
}

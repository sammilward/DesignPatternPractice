using Design_Pattern_Code.Ducks_2___Adapter_Pattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern_Code
{
    public class TurkeyAdapter : IDuck
    {
        private ITurkey _turkey;
        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }
        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                _turkey.Fly();
            }
        }

        public void Quack()
        {
            _turkey.Gobble();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Dog : Animal
    {
        public Dog() : base()
        {
            Sound = "Bark";
            FlyingType = new CantFlys();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Bird : Animal
    {
        public Bird() : base() 
        {
            Sound = "Tweet";
            FlyingType = new ItFlys();
        }
    }
}

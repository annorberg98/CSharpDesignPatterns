using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface IFlys
    {
        string Fly();
    }

    public class ItFlys : IFlys
    {
        public string Fly()
        {
            return "Flying High";
        }
    }

    public class CantFlys : IFlys
    {
        public string Fly()
        {
            return "I cant fly";
        }
    }
}

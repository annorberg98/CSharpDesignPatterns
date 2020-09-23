using System;

namespace StrategyPattern
{
    public class Animal
    {
        private string name;
        private double height;
        private int weight;
        private string favFood;
        private double speed;
        private string sound;

        private IFlys flyingType;
        public string Name { get => name; set => name = value; }

        public double Height { get => height; set => height = value; }
        public int Weight { get => weight; set => weight = value; }
        public string FavFood { get => favFood; set => favFood = value; }
        public double Speed { get => speed; set => speed = value; }
        public string Sound { get => sound; set => sound = value; }
        public IFlys FlyingType { get => flyingType; set => flyingType = value; }

        public string TryToFly()
        {
            return flyingType.Fly();
        }

        
    }
}

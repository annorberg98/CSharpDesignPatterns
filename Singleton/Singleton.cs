namespace Singleton
{
    public class Singleton
    {
        private static Singleton firstInstance = null;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (firstInstance == null)
            {
                firstInstance = new Singleton();
            }
            return firstInstance;
        }

    }
}

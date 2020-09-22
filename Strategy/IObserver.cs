namespace ObserverPattern
{
    public interface IObserver
    {
        public void Update(double ibmPrice, double aaplPrice, double googPrice);
    }
}

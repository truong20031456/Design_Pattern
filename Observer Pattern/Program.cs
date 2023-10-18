namespace Observer_Pattern
{
    using System;
    using System.Collections.Generic;

    public interface ISubject
    {
        void Register(IObserver observer);
        void Unregister(IObserver observer);
        void Notify();
    }

    public interface IObserver
    {
        void Update(string message);
    }

    public class WeatherData : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string weatherMessage;

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(weatherMessage);
            }
        }

        public void SetWeatherData(string message)
        {
            weatherMessage = message;
            Notify();
        }
    }

    public class Display : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Display: {message}");
        }
    }

    class Program
    {
        static void Main()
        {
            WeatherData weatherStation = new WeatherData();
            Display display1 = new Display();
            Display display2 = new Display();

            weatherStation.Register(display1);
            weatherStation.Register(display2);

            weatherStation.SetWeatherData("Temperature is 25°C");
            // Output:
            // Display: Temperature is 25°C
            // Display: Temperature is 25°C
        }
    }

}
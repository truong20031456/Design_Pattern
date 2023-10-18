namespace Adapter_Pattern
{
    using System;

    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee's specific request.");
        }
    }

    public interface ITarget
    {
        void Request();
    }

    public class Adapter : ITarget
    {
        private readonly Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Request()
        {
            adaptee.SpecificRequest();
        }
    }

    class Program
    {
        static void Main()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            target.Request();    // Output: Adaptee's specific request.
        }
    }

}
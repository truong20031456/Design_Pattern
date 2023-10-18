namespace Singleto_Pattern

{
    using System;

    public class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }

    class Program
    {
        static void Main()
        {
            Singleton instance1 = Singleton.GetInstance();
            Singleton instance2 = Singleton.GetInstance();

            if (instance1 == instance2)
            {
                Console.WriteLine("Both instances are the same.");
            }
        }
    }

}
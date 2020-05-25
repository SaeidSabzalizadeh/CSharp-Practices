using DesignPatternsLibrary.Decorator.Component;
using DesignPatternsLibrary.Decorator.ConcreteComponent;
using DesignPatternsLibrary.Decorator.ConcreteDecorator;
using System;

namespace DesignPatternsLibrary.Decorator
{
    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            Car compactCar = new CompactCar();
            compactCar = new Navigation(compactCar);
            compactCar = new Sunroof(compactCar);
            compactCar = new LeatherSeats(compactCar);

            Console.WriteLine(compactCar.GetDescription());
            Console.WriteLine($"{compactCar.GetCarPrice():C2}");
            Console.ReadKey();
        }

    }
}

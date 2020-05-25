using DesignPatternsLibrary.Decorator.Component;
using DesignPatternsLibrary.Decorator.Decorator;

namespace DesignPatternsLibrary.Decorator.ConcreteDecorator
{
    public class Sunroof : CarDecorator
    {
        public Sunroof(Car car) : base(car)
        {
            Description = "Sunroof";
        }

        public override string GetDescription() => $"{_car.GetDescription()}, {Description}";

        public override double GetCarPrice() => _car.GetCarPrice() + 2500;
    }
}

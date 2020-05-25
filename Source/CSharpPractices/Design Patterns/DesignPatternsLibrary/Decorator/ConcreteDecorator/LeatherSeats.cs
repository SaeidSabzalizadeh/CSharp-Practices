using DesignPatternsLibrary.Decorator.Component;
using DesignPatternsLibrary.Decorator.Decorator;

namespace DesignPatternsLibrary.Decorator.ConcreteDecorator
{
    //ConcreteDecorator
    public class LeatherSeats : CarDecorator
    {
        public LeatherSeats(Car car) : base(car)
        {
            Description = "Leather Seats";
        }

        public override string GetDescription() => $"{_car.GetDescription()},  {Description}";

        public override double GetCarPrice() => _car.GetCarPrice() + 2500;
    }
}

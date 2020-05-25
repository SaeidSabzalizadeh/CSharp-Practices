using DesignPatternsLibrary.Decorator.Component;

namespace DesignPatternsLibrary.Decorator.ConcreteComponent
{
    // ConcreteComponent
    public class FullSizeCar : Car
    {
        public FullSizeCar()
        {
            Description = "FullSize Car";
        }

        public override double GetCarPrice() => 30000.00;
        public override string GetDescription() => Description;
    }
}

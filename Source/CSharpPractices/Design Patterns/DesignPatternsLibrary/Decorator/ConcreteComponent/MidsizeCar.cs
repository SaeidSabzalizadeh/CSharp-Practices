using DesignPatternsLibrary.Decorator.Component;

namespace DesignPatternsLibrary.Decorator.ConcreteComponent
{
    // ConcreteComponent
    public class MidsizeCar : Car
    {
        public MidsizeCar()
        {
            Description = "Midsize Car";
        }

        public override double GetCarPrice() => 20000.00;
        public override string GetDescription() => Description;
    }
}

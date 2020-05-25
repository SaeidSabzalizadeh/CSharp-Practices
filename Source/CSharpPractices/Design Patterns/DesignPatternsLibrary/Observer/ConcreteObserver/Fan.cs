using DesignPatternsLibrary.Observer.Observer;
using DesignPatternsLibrary.Observer.Subject;
using System;

namespace DesignPatternsLibrary.Observer.ConcreteObserver
{
    // Concrete Observer
    public class Fan : IFan
    {
        public void Update(ICelebrity celebrity)
        {
            Console.WriteLine($"Fan notified. Tweet of {celebrity.FullName}: " +
                $"{celebrity.Tweet}");
        }
    }
}

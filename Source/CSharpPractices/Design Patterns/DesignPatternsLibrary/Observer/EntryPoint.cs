using DesignPatternsLibrary.Observer.ConcreteObserver;
using DesignPatternsLibrary.Observer.ConcreteSubject;
using System;

namespace DesignPatternsLibrary.Observer
{
    public  class EntryPoint
    {
       public static void Main(string[] args)
        {
            var gClooney = new GClooney("I love my new wife");
            var tSwift = new TSwift("1981 is now my favorite number.");

            var firstFan = new Fan();
            var secondFan = new Fan();

            gClooney.AddFollower(firstFan);
            tSwift.AddFollower(secondFan);

            gClooney.Tweet = "My wife didn't force me to tweet.";
            tSwift.Tweet = "I love my new music.";

            Console.Read();
        }
    }
}

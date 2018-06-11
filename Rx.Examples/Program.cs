using System;
using System.Reactive.Linq;

namespace Rx.Examples
{
    class Program
    {
        static void Main()
        {
            var trivialObervableGenerator = new TrivialObervableGenerator();

            // -1- Here, we are just grabbing the items which the observable is pumping and writing
            // them to the console in a formatted way.
            var environmentalVariablesSubscription = trivialObervableGenerator.GetEnvironmentalVariables()
                .Subscribe(kvp => Console.WriteLine($"{kvp.Key,45} -\t {kvp.Value}"));


            Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Working ... {Environment.NewLine}");

            // -2- In this case, we are creating a new subscription (starting the pump all over again)
            // and performing some LINQ queries on the items being pumped, before writing them to the console.
            // You will note a varying delay between the output values because our LINQ queries are
            // discarding the ones we are not interested in as they arrive with the filtering.
            var filteringSubscription = trivialObervableGenerator.GetEnvironmentalVariables()
                .Where(kvp => kvp.Key.StartsWith("Program"))
                .Select(kvp => string.Concat($"{kvp.Key,18}", "\t=====>\t", kvp.Value))
                .Subscribe(Console.WriteLine);

            Console.ReadLine();

            environmentalVariablesSubscription.Dispose();
            filteringSubscription.Dispose();
        }
    }
}

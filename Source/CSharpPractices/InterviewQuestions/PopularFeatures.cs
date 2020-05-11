using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewQuestions
{
    public class PopularFeatures
    {
        public static void Run()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Get Popular feature lists based on reviews among possible features");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            var list = GetPopularFeatures(3, 2, new List<string>() { "storage", "battery", "Lemon" }, 5, new List<string>() { "my battery", "me storage", "my battery again", "my Lemon", "my storage again" });

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------------------------");

        }

        private static List<string> GetPopularFeatures(int numFeatures, int topFeatures, List<string> possibleFeatures, int numFeatureRequests, List<string> featureRequests)
        {

            if (numFeatures <= 0 || topFeatures <= 0 || numFeatureRequests <= 0)
                return null;

            Dictionary<string, int> requestedFeatureCount = new Dictionary<string, int>();

            for (int i = 0; i < numFeatureRequests; i++)
            {
                var featureReques = featureRequests[i];

                for (int j = 0; j < numFeatures; j++)
                {
                    var feature = possibleFeatures[j];

                    if (featureReques.Contains(feature))
                    {
                        if (requestedFeatureCount.ContainsKey(feature))
                            requestedFeatureCount[feature] = requestedFeatureCount[feature] + 1;
                        else
                            requestedFeatureCount.Add(feature, 1);
                    }
                }
            }

            var orderedList = requestedFeatureCount.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();

            if (orderedList == null || orderedList.Count == 0)
                return null;

            if (topFeatures > orderedList.Count)
                return orderedList.Select(x => x.Key).ToList();


            return orderedList.Take(topFeatures).Select(x => x.Key).ToList();

        }


    }
}

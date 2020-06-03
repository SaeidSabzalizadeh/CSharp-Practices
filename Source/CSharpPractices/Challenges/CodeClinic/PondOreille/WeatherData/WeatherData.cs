using System;
using System.Collections.Generic;
using System.IO;

namespace WeatherData
{
    public class WeatherData
    {
        public static IEnumerable<WeatherObservation> ReadAll(TextReader text, Action<string> errorHandler = null)
        {
            string line = null;
            while ((line = text.ReadLine()) != null)
            {
                if (WeatherObservation.TryParse(line, out WeatherObservation wo))
                {
                    yield return wo;
                }
                else
                {
                    try
                    {
                        errorHandler?.Invoke(line);
                    }
                    catch { }
                }
            }
        }

    }
}

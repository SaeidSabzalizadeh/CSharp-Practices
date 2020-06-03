﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WeatherData
{
    public class WeatherData
    {

        public static IEnumerable<WeatherObservation> ReadRange(
           TextReader text,
           DateTime? start = null,
           DateTime? end = null,
           Action<string> errorHandler = null)
        {
            return
                ReadAll(text, errorHandler)
                    .SkipWhile((wo) => wo.TimeStamp < (start ?? DateTime.MinValue))
                    .TakeWhile((wo) => wo.TimeStamp <= (end ?? DateTime.MaxValue));
        }

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

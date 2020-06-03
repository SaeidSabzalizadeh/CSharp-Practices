using NFluent;
using System;
using Xunit;

namespace WeatherData.Tests
{
    public class Tests
    {
        [Fact]
        public void Test_010_ParseLine()
        {
            var text = "2012_01_01 00:02:14	34.30	30.50	26.90	74.20	346.40	11.00	 3.60";

            var wo = WeatherObservation.Parse(text);

            Check.That(wo.TimeStamp).IsEqualTo(new DateTime(2012, 01, 01, 00, 02, 14));
            Check.That(wo.Barometric_Pressure).IsCloseTo(30.5, 0.01);
        }

        [Fact]
        public void Test_020_TryParseLine()
        {
            var text = "2012_01_01 00:02:14	34.30	30.50	26.90	74.20	346.40	11.00	 3.60";

            var tryParseOutcome = WeatherObservation.TryParse(text, out WeatherObservation wo);

            Check.That(tryParseOutcome).IsTrue();
            Check.That(wo.TimeStamp).IsEqualTo(new DateTime(2012, 01, 01, 00, 02, 14));
            Check.That(wo.Barometric_Pressure).IsCloseTo(30.5, 0.01);
        }

    }
}

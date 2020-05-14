using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace ProgrammingTest.NetCore
{
    public class IDisposableFeatures
    {
        static string filename = $@"{Directory.GetCurrentDirectory()}\Environmental_Data_Deep_Moor_2012.txt";

        [Fact]
        public void Test_010_FileStream()
        {
            Assert.True(File.Exists(filename));

            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);

            var b1 = fs.ReadByte();
            var c1 = (char)b1;
            Assert.True(c1 == 'd');

            fs.Close();
        }

        [Fact]
        public void Test_011_FileStream()
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(filename, FileMode.Open, FileAccess.Read);

                var b1 = fs.ReadByte();
                var c1 = (char)b1;
                Assert.True(c1 == 'd');
            }
            finally
            {
                fs?.Close();
            }
        }

        [Fact]
        public void Test_012_FileStream()
        {
            FileStream fs = null;
            IDisposable idfs = fs;

            try
            {
                fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                Assert.True(fs is IDisposable);

                var b1 = fs.ReadByte();
                var c1 = (char)b1;
                Assert.True(c1 == 'd');
            }
            finally
            {
                idfs?.Dispose();
            }
        }

        [Fact]
        public void Test_013_FileStream()
        {
            using (var fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            //FileStream fs = null;
            //IDisposable idfs = fs;
            //try
            {
                //fs = new FileStream(filename, FileMode.Open, FileAccess.Read);

                var b1 = fs.ReadByte();
                var c1 = (char)b1;
                Assert.True(c1 == 'd');
            }
            //finally
            //{
            //    idfs?.Dispose();
            //}
        }

        [Fact]
        public void Test_014_FileStream()
        {
            using (var sr = new StreamReader(filename))
            {
                var line1 = sr.ReadLine();
            }
        }


        [Fact]
        public void Test_015_FileStream()
        {
            using (var sr = new StreamReader(filename))
            {
                var line1 = sr.ReadLine();

                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    var data = line.Split('\t');
                    Assert.True(data.Length == 8);
                }
            }
        }

        [Fact]
        public void Test_016_FileStream()
        {
            using (var sr = new StreamReader(filename))
            {
                var line1 = sr.ReadLine();

                IEnumerator<string> e = GetData(sr).GetEnumerator();
                while (e.MoveNext())
                {
                    var data = e.Current.Split('\t');
                }
            }
        }


        [Fact]
        public void Test_017_FileStream()
        {
            using (var sr = new StreamReader(filename))
            {
                var line1 = sr.ReadLine();

                foreach (var line in GetData(sr))
                {
                    var data = line.Split('\t');
                }
            }
        }

        [Fact]
        public void Test_018_FileStream()
        {
            using (var sr = new StreamReader(filename))
            {
                var line1 = sr.ReadLine();

                foreach (var line in GetTextData(sr))
                {
                    var data = line.Split('\t');
                }
            }
        }

        [Fact]
        public void Test_019_FileStream()
        {
            string text =
@"date       time    	Air_Temp	Barometric_Press	Dew_Point	Relative_Humidity	Wind_Dir	Wind_Gust	Wind_Speed
2015_01_01 00:02:43	19.50	30.62	14.78	81.60	159.78	14.00	 9.20
2015_01_01 00:02:52	19.50	30.62	14.78	81.60	159.78	14.00	 9.20
2015_01_01 00:07:43	19.50	30.61	14.66	81.20	155.63	11.00	 8.60
2015_01_01 00:07:52	19.50	30.61	14.66	81.20	155.63	11.00	 8.60";

            using (var sr = new StringReader(text))
            {
                var line1 = sr.ReadLine();

                foreach (var line in GetTextData(sr))
                {
                    var data = line.Split('\t');
                }
            }
        }



        private static IEnumerable<string> GetData(StreamReader sr)
        {
            string line = null;
            while ((line = sr.ReadLine()) != null)
            {
                yield return line;
            }
        }


        private static IEnumerable<string> GetTextData(TextReader text)
        {
            string line = null;
            while ((line = text.ReadLine()) != null)
            {
                yield return line;
            }
        }

    }
}

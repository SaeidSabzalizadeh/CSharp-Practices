using System.Collections.Generic;
using System.Diagnostics;
using Xunit;

namespace XUnitTest.NetCore
{
    public class IEnumerableFeatures
    {
        [Fact]
        public void Test_001()
        {
            var numbers = new List<int> { 1, 3, 5, 7, 11 };

            Assert.True(numbers is IEnumerable<int>);

            var e = numbers.GetEnumerator();
            Assert.True(e is IEnumerator<int>);

            bool hasData = e.MoveNext();
            Assert.True(hasData);

            int i = e.Current;
            Assert.True(i == 1);


            hasData = e.MoveNext();
            Assert.True(hasData);

            i = e.Current;
            Assert.True(i == 3);

        }

        [Fact]
        public void Test_002()
        {
            var numbers = new List<int> { 1, 3, 5, 7, 11 };

            Assert.True(numbers is IEnumerable<int>);

            var e = numbers.GetEnumerator();
            Assert.True(e is IEnumerator<int>);

            while (e.MoveNext())
            {
                int i = e.Current;
                Debug.WriteLine($"{nameof(Test_002)}::{nameof(i)}::{i}");
            }
        }

        [Fact]
        public void Test_003()
        {
            var numbers = new List<int> { 1, 3, 5, 7, 11 };

            Assert.True(numbers is IEnumerable<int>);

            foreach (var i in numbers)
            {
                Debug.WriteLine($"{nameof(Test_003)}::{nameof(i)}::{i}");
            }
        }

        [Fact]
        public void Test_004()
        {
            var a = new int[] { 1, 3, 5, 7, 11 };
            Assert.True(a is IEnumerable<int>);
            Assert.True(a is IList<int>);

            var l = new List<int>() { 1, 3, 5, 7, 11 };
            Assert.True(l is IEnumerable<int>);
            Assert.True(l is IList<int>);
        }


    }
}

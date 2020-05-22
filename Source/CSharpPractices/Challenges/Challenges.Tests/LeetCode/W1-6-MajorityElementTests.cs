using System.Linq;
using Xunit;

namespace Challenges.Tests.LeetCode
{
    public class MajorityElementTests
    {

        [Theory]
        [InlineData("1", 1)]
        [InlineData("3,2,3", 3)]
        [InlineData("2,2,1,1,1,2,2", 2)]
        [InlineData("1,2,3,4,25,6,7,5,4,3,5,6,78,4,3,2,7,7,4,6,7,7,3,2,7,8,7,8,7,9,7,8,7,4,6,7,2,7,3,7,7,7,74", int.MinValue)]
        [InlineData("1,7,7,7,25,6,7,5,4,3,7,6,78,7,3,2,7,7,7,6,7,7,3,2,7,8,7,8,7,7,7,8,7,4,6,7,2,7,3,7,7,7,74", 7)]
        public void ValidMajorityElement(string numbersStr, int expectedResult)
        {
            int[] numbers = numbersStr.Split(',').Select(x => int.Parse(x.Trim())).ToArray();
            var result = Library.LeetCode.MajorityElement.FindMajorityElement_Dictionary(numbers);
            Assert.True(result == expectedResult, $"{nameof(Library.LeetCode.MajorityElement.FindMajorityElement_Dictionary)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{numbersStr}'");
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("3,2,3", 3)]
        [InlineData("2,2,1,1,1,2,2", 2)]
        [InlineData("1,2,3,4,25,6,7,5,4,3,5,6,78,4,3,2,7,7,4,6,7,7,3,2,7,8,7,8,7,9,7,8,7,4,6,7,2,7,3,7,7,7,74", int.MinValue)]
        [InlineData("1,7,7,7,25,6,7,5,4,3,7,6,78,7,3,2,7,7,7,6,7,7,3,2,7,8,7,8,7,7,7,8,7,4,6,7,2,7,3,7,7,7,74", 7)]
        public void ValidMajorityElementII(string numbersStr, int expectedResult)
        {
            int[] numbers = numbersStr.Split(',').Select(x => int.Parse(x.Trim())).ToArray();
            var result = Library.LeetCode.MajorityElement.FindMajorityElementII_ImprovedDictionary(numbers);
            Assert.True(result == expectedResult, $"{nameof(Library.LeetCode.MajorityElement.FindMajorityElementII_ImprovedDictionary)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{numbersStr}'");
        }


        [Theory]
        [InlineData("1", 1)]
        //[InlineData("3,2,3", 3)]
        //[InlineData("2,2,1,1,1,2,2", 2)]
        //[InlineData("1,2,3,4,25,6,7,5,4,3,5,6,78,4,3,2,7,7,4,6,7,7,3,2,7,8,7,8,7,9,7,8,7,4,6,7,2,7,3,7,7,7,74", int.MinValue)]
        //[InlineData("1,7,7,7,25,6,7,5,4,3,7,6,78,7,3,2,7,7,7,6,7,7,3,2,7,8,7,8,7,7,7,8,7,4,6,7,2,7,3,7,7,7,74", 7)]
        public void ValidMajorityElementIII(string numbersStr, int expectedResult)
        {
            int[] numbers = numbersStr.Split(',').Select(x => int.Parse(x.Trim())).ToArray();
            var result = Library.LeetCode.MajorityElement.FindMajorityElementIII_LinqSort(numbers);
            Assert.True(result == expectedResult, $"{nameof(Library.LeetCode.MajorityElement.FindMajorityElementIII_LinqSort)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{numbersStr}'");
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("3,2,3", 3)]
        [InlineData("2,2,1,1,1,2,2", 2)]
        [InlineData("1,2,3,4,25,6,7,5,4,3,5,6,78,4,3,2,7,7,4,6,7,7,3,2,7,8,7,8,7,9,7,8,7,4,6,7,2,7,3,7,7,7,74", int.MinValue)]
        [InlineData("1,7,7,7,25,6,7,5,4,3,7,6,78,7,3,2,7,7,7,6,7,7,3,2,7,8,7,8,7,7,7,8,7,4,6,7,2,7,3,7,7,7,74", 7)]
        public void ValidMajorityElementIV(string numbersStr, int expectedResult)
        {
            int[] numbers = numbersStr.Split(',').Select(x => int.Parse(x.Trim())).ToArray();
            var result = Library.LeetCode.MajorityElement.FindMajorityElementIV_LinqSortIndirect(numbers);
            Assert.True(result == expectedResult, $"{nameof(Library.LeetCode.MajorityElement.FindMajorityElementIV_LinqSortIndirect)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{numbersStr}'");
        }


        [Theory]
        [InlineData("1", 1)]
        [InlineData("3,2,3", 3)]
        [InlineData("2,2,1,1,1,2,2", 2)]
        [InlineData("1,2,3,4,25,6,7,5,4,3,5,6,78,4,3,2,7,7,4,6,7,7,3,2,7,8,7,8,7,9,7,8,7,4,6,7,2,7,3,7,7,7,74", int.MinValue)]
        [InlineData("1,7,7,7,25,6,7,5,4,3,7,6,78,7,3,2,7,7,7,6,7,7,3,2,7,8,7,8,7,7,7,8,7,4,6,7,2,7,3,7,7,7,74", 7)]
        public void ValidMajorityElementV(string numbersStr, int expectedResult)
        {
            int[] numbers = numbersStr.Split(',').Select(x => int.Parse(x.Trim())).ToArray();
            var result = Library.LeetCode.MajorityElement.FindMajorityElementV_InsertionSort(numbers);
            Assert.True(result == expectedResult, $"{nameof(Library.LeetCode.MajorityElement.FindMajorityElementV_InsertionSort)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{numbersStr}'");
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("3,2,3", 3)]
        [InlineData("2,2,1,1,1,2,2", 2)]
        [InlineData("1,2,3,4,25,6,7,5,4,3,5,6,78,4,3,2,7,7,4,6,7,7,3,2,7,8,7,8,7,9,7,8,7,4,6,7,2,7,3,7,7,7,74", int.MinValue)]
        [InlineData("1,7,7,7,25,6,7,5,4,3,7,6,78,7,3,2,7,7,7,6,7,7,3,2,7,8,7,8,7,7,7,8,7,4,6,7,2,7,3,7,7,7,74", 7)]
        public void ValidMajorityElementVIII(string numbersStr, int expectedResult)
        {
            int[] numbers = numbersStr.Split(',').Select(x => int.Parse(x.Trim())).ToArray();
            var result = Library.LeetCode.MajorityElement.FindMajorityElementVIII_Loops(numbers);
            Assert.True(result == expectedResult, $"{nameof(Library.LeetCode.MajorityElement.FindMajorityElementVIII_Loops)} does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{numbersStr}'");
        }

    }
}

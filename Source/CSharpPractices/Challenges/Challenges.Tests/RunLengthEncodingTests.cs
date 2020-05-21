using Xunit;

namespace Challenges.Tests
{
    public class RunLengthEncodingTests
    {
        [Theory]
        [InlineData("aaaabbccc", "4a2b3c")]
        [InlineData("aaaabbccca", "4a2b3c1a")]
        [InlineData("", "")]
        [InlineData(" ", "1 ")]
        [InlineData(null, null)]
        public void ValidRunLengthEncoding(string input, string expectedResult)
        {
            var result = Library.RunLengthEncoding.Encode(input);
            Assert.True(result == expectedResult, $"RunLengthEncoding does not meet the expected. Solution result is '{result}' but expected is '{expectedResult}' for: '{input}'");
        }

    }
}

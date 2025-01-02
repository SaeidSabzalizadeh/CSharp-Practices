using Xunit;

namespace Challenges.Other.Tests;

public class AZ_Preparation04Tests
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([)]", false)]
    [InlineData("{[]}", true)]
    [InlineData("", true)] // Edge case: empty string
    [InlineData("{[()()]}", true)]
    [InlineData("{[()()]}[", false)]
    [InlineData("(", false)] // Single opening bracket
    [InlineData(")", false)] // Single closing bracket
    [InlineData("([{}])", true)]
    [InlineData("([{{[(())]}}])", true)]
    [InlineData("{[}", false)] // Mismatched brackets

    public void AZ_CheckDuplicate_Method1_IsValid(string input, bool expectedResult)
    {
        bool result = AZ_Preparation04.Run1(input);
        Assert.True(result == expectedResult, $"AZ_Preparation04.Run1() does not return as expected. Actual result is [{result}] but expected is [{expectedResult}] for: '{input}'");
    }

    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([)]", false)]
    [InlineData("{[]}", true)]
    [InlineData("", true)] // Edge case: empty string
    [InlineData("{[()()]}", true)]
    [InlineData("{[()()]}[", false)]
    [InlineData("(", false)] // Single opening bracket
    [InlineData(")", false)] // Single closing bracket
    [InlineData("([{}])", true)]
    [InlineData("([{{[(())]}}])", true)]
    [InlineData("{[}", false)] // Mismatched brackets

    public void AZ_CheckDuplicate_Method2_IsValid(string input, bool expectedResult)
    {
        bool result = AZ_Preparation04.Run2(input);
        Assert.True(result == expectedResult, $"AZ_Preparation04.Run2() does not return as expected. Actual result is [{result}] but expected is [{expectedResult}] for: '{input}'");
    }
}

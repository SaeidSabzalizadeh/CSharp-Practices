using System;
using System.Collections.Generic;
using Xunit;

namespace Challenges.Other.Tests;

public class AZ03Tests
{
    [Fact]
    public void TestGenerateReport1()
    {
        var employeeList = new List<EmployeeTicket>
    {
        new EmployeeTicket("David", 1, "Steve"),
        new EmployeeTicket("Lisa", 4, "David"),
        new EmployeeTicket("Adam", 3, "David"),
        new EmployeeTicket("Andy", 5, "David"),
        new EmployeeTicket("Yan", 7, "Lily"),
        new EmployeeTicket("Lily", 0, "Steve")
    };

        var expected = new Dictionary<string, int>
    {
        { "Steve", 20 },
        { "David", 13 },
        { "Lisa", 4 },
        { "Adam", 3 },
        { "Andy", 5 },
        { "Lily", 7 },
        { "Yan", 7 }
    };

        var result = AZ03.GenerateReport(employeeList);

        Assert.True(IsSameDictionary(expected, result));
    }



    [Fact]
    public void TestGenerateReport2()
    {
        var employeeList = new List<EmployeeTicket>
    {
        new EmployeeTicket("A", 2, ""),
        new EmployeeTicket("B", 3, "A"),
        new EmployeeTicket("C", 5, "B"),
        new EmployeeTicket("D", 7, "B")
    };

        var expected = new Dictionary<string, int>
    {
        { "A", 17 },
        { "B", 15 },
        { "C", 5 },
        { "D", 7 }
    };

        var result = AZ03.GenerateReport(employeeList);

        Assert.True(IsSameDictionary(expected, result));
    }

    [Fact]
    public void TestGenerateReport3()
    {
        var employeeList = new List<EmployeeTicket>
    {
        new EmployeeTicket("John", 10, "Jane"),
        new EmployeeTicket("Jane", 5, "Doe"),
        new EmployeeTicket("Doe", 0, "")
    };

        var expected = new Dictionary<string, int>
    {
        { "Doe", 15 },
        { "Jane", 15 },
        { "John", 10 }
    };

        var result = AZ03.GenerateReport(employeeList);

        Assert.True(IsSameDictionary(expected, result));
    }

    [Fact]
    public void TestGenerateReport4()
    {
        var employeeList = new List<EmployeeTicket>
    {
        new EmployeeTicket("E", 1, "F"),
        new EmployeeTicket("F", 2, ""),
        new EmployeeTicket("G", 3, "F"),
        new EmployeeTicket("H", 4, "G")
    };

        var expected = new Dictionary<string, int>
    {
        { "F", 10 },
        { "E", 1 },
        { "G", 7 },
        { "H", 4 }
    };

        var result = AZ03.GenerateReport(employeeList);

        Assert.True(IsSameDictionary(expected, result));
    }

    [Fact]
    public void TestGenerateReport5()
    {
        var employeeList = new List<EmployeeTicket>
    {
        new EmployeeTicket("X", 0, ""),
        new EmployeeTicket("Y", 0, "X"),
        new EmployeeTicket("Z", 0, "Y")
    };

        var expected = new Dictionary<string, int>
    {
        { "X", 0 },
        { "Y", 0 },
        { "Z", 0 }
    };

        var result = AZ03.GenerateReport(employeeList);

        Assert.True(IsSameDictionary(expected, result));
    }

    private bool IsSameDictionary(Dictionary<string, int> expected, Dictionary<string, int> result)
    {
        if (expected.Count != result.Count)
        {
            return false;
        }

        foreach (var item in expected)
        {
            if (result[item.Key] != item.Value)
            {
                return false;
            }
        }

        return true;

    }

}

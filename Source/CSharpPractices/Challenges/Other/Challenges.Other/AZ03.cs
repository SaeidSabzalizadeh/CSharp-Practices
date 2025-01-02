using System.Collections.Generic;

namespace Challenges.Other;

/// <summary>
/// mplement the function to generate the daily report of the number of completed tickets 
/// of the organizations based on the report chain.
/// 
/// Dictionary<string, int> generateReport(List<EmployeeTicket> employeeTickets);
/// 
/// Input:
/// name      completed  reportTo
/// David     1          Steve
/// Lisa      4          David
/// Adam      3          David
/// Andy      5          David
/// Yan       7          Lily
/// Lily      0          Steve
/// 
/// Output:
/// Steve: 20,
/// David: 13,
/// Lisa: 4,
/// Adam: 3,
/// Andy: 5,
/// Lily: 7,
/// Yan: 7
/// 
/// </summary>
public class AZ03
{
    public static Dictionary<string, int> GenerateReport(List<EmployeeTicket> employeeTickets)
    {
        // Step 1: Build the reporting hierarchy
        var reportMap = new Dictionary<string, List<string>>();
        var ticketsMap = new Dictionary<string, int>();
        var output = new Dictionary<string, int>();

        foreach (var emp in employeeTickets)
        {
            if (!reportMap.ContainsKey(emp.ReportTo))
            {
                reportMap[emp.ReportTo] = new List<string>();
            }
            reportMap[emp.ReportTo].Add(emp.Name);
            ticketsMap[emp.Name] = emp.Completed;

            if (!ticketsMap.ContainsKey(emp.ReportTo))
            {
                ticketsMap[emp.ReportTo] = 0;
            }

        }

        // Step 2: Helper function to calculate total tickets using DFS
        int CalculateTotalTickets(string employee)
        {
            if (!reportMap.ContainsKey(employee))
            {
                return ticketsMap[employee];
            }

            int totalTickets = ticketsMap[employee];
            foreach (var subordinate in reportMap[employee])
            {
                totalTickets += CalculateTotalTickets(subordinate);
            }
            return totalTickets;
        }

        // Step 3: Calculate total tickets for each employee starting from top-level employees
        foreach (var emp in ticketsMap)
        {
            output[emp.Key] = CalculateTotalTickets(emp.Key);
        }

        return output;
    }
}



public class EmployeeTicket
{
    public string Name { get; set; }
    public int Completed { get; set; }
    public string ReportTo { get; set; }

    public EmployeeTicket(string name, int completed, string reportTo)
    {
        Name = name;
        Completed = completed;
        ReportTo = reportTo;
    }
}

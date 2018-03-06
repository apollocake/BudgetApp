using System.Collections.Generic;

namespace ConsoleApp1
{
    public interface ILogicProvider
    {
        decimal MonthlySum(List<IBudgetItem> budgetItems);
    }
}
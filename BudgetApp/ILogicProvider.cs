using System.Collections.Generic;

namespace BudgetApp
{
    public interface ILogicProvider
    {
        decimal MonthlySum(List<IBudgetItem> budgetItems);
    }
}
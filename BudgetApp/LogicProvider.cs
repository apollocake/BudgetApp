using System.Collections.Generic;

namespace BudgetApp
{
    internal class LogicProvider : ILogicProvider
    {
        public decimal MonthlySum(List<IBudgetItem> budgetItems)
        {
            decimal sum = 0;
            foreach (var b in budgetItems)
            {
                if (b.Cycle == Cycle.Yearly)
                {
                    sum += b.Cost / 12.0m;
                }
                else if (b.Cycle == Cycle.Monthly)
                {
                    sum += b.Cost;
                }
            }
            return sum;
        }
    }
}
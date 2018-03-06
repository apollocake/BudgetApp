using System.Collections.Generic;

namespace BudgetApp
{
    internal class StaticModel : IServiceModel
    {
        public List<IBudgetItem> DebtList
        {
            get
            {
                var debtList = new List<IBudgetItem>
                {
                    new BudgetItem() { Name = "Github", Cycle = Cycle.Monthly, Cost = 7.00m },
                    new BudgetItem() { Name = "mydomain.com", Cycle = Cycle.Yearly, Cost = 89.00m },
                    new BudgetItem() { Name = "snacks", Cycle = Cycle.NA, Cost = 130.00m },
                    new BudgetItem() { Name = "rent", Cycle = Cycle.Monthly, Cost = 0 },
                    new BudgetItem() { Name = "Loans", Cycle = Cycle.Monthly, Cost = 0 },
                    new BudgetItem() { Name = "Insurance", Cycle = Cycle.Monthly, Cost = 0 },
                    new BudgetItem() { Name = "Best Buy", Cycle = Cycle.NA, Cost = 200m },
                    new BudgetItem() { Name = "PSN", Cycle = Cycle.Yearly, Cost = 60m }
                };
                return debtList;
            }
        }
        public List<IBudgetItem> ProfitList
        {
            get
            {
                var profitList = new List<IBudgetItem>()
                {
                    new BudgetItem() { Name = "Red Inc", Cycle = Cycle.Monthly, Cost = 1000m }
                };
                return profitList;
            }
        }
    }
}
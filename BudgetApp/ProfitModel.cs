using System.Collections.Generic;

namespace BudgetApp
{
    internal class ProfitModel : ILedger
    {
        private List<IBudgetItem> budgetList;

        internal ProfitModel(List<IBudgetItem> budgetList)
        {
            this.budgetList = budgetList;
        }

        public List<IBudgetItem> BudgetItems
        {
            get { return this.budgetList; }
            set { this.budgetList = value; }
        }
    }
}
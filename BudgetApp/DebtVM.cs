using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class DebtModel : ILedger
    {
        private List<IBudgetItem> budgetList;

        internal DebtModel(List<IBudgetItem> budgetList)
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
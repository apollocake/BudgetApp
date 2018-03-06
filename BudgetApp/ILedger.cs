using System.Collections.Generic;

namespace BudgetApp
{
    internal interface ILedger
    {
        List<IBudgetItem> BudgetItems { get; set; }
    }
}
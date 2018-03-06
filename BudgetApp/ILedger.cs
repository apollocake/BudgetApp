using System.Collections.Generic;

namespace ConsoleApp1
{
    internal interface ILedger
    {
        List<IBudgetItem> BudgetItems { get; set; }
    }
}
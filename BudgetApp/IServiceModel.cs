using System.Collections.Generic;

namespace BudgetApp
{
    interface IServiceModel
    {
        List<IBudgetItem> DebtList { get; }
        List<IBudgetItem> ProfitList { get; }

    }
}
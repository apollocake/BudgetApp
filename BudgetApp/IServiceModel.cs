using System.Collections.Generic;

namespace ConsoleApp1
{
    interface IServiceModel
    {
        List<IBudgetItem> DebtList { get; }
        List<IBudgetItem> ProfitList { get; }

    }
}
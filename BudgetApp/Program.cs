using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceModel staticModel = new StaticModel();
            List<IBudgetItem> debtItems = staticModel.DebtList;
            List<IBudgetItem> profitItems  = staticModel.ProfitList;
            ILedger debtViewModel = new DebtModel(debtItems);
            ILedger profitViewModel = new ProfitModel(profitItems);
            ILogicProvider  logicProvider = new LogicProvider();
            var mainBudgetViewModel = new MainBudgetVM(debtViewModel, profitViewModel, logicProvider);
            Console.ReadKey();
        }
    }
}

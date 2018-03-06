using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ConsoleApp1
{
    internal class MainBudgetVM : IMainBudgetVM
    {
        private ILedger debtModel;
        private ILedger profitModel;
        private ILogicProvider logicProvider;

        public GraphObject GraphObject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Legend Legend { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public MainBudgetVM(ILedger debtModel, ILedger profitModel, ILogicProvider logicProvider)
        {
            this.debtModel = debtModel;
            this.profitModel = profitModel;
            this.logicProvider = logicProvider;
            this.DisplayLossModel(this.debtModel);
            this.DisplayProfitModel(this.profitModel);
            this.DisplayNetProfitModel(this.debtModel, this.profitModel);
        }

        private void DisplayNetProfitModel(ILedger debtModel, ILedger profitModel)
        {
            decimal sum = 0;
            sum -= logicProvider.MonthlySum(debtModel.BudgetItems);
            sum += logicProvider.MonthlySum(profitModel.BudgetItems);

            Console.WriteLine("Montthly Net Profit: " + sum.ToString("C", CultureInfo.CurrentCulture));
        }

        private void DisplayProfitModel(ILedger profitModel)
        {
            profitModel.BudgetItems.ForEach(x => Console.WriteLine($"{x.Name} {x.Cycle} {x.Cost}"));

            decimal monthlySum = logicProvider.MonthlySum(profitModel.BudgetItems);
            Console.WriteLine("Items Total: " + profitModel.BudgetItems.Select(x => x.Cost).Sum());
            Console.WriteLine("Monthly Profit: " + monthlySum.ToString("C", CultureInfo.CurrentCulture));
        }

        private void DisplayLossModel(ILedger debtModel)
        {
            debtModel.BudgetItems.ForEach(x => Console.WriteLine($"{x.Name} {x.Cycle} {x.Cost}"));

            decimal monthlySum = logicProvider.MonthlySum(debtModel.BudgetItems);
            Console.WriteLine("Items Total: " + debtModel.BudgetItems.Select(x => x.Cost).Sum());
            Console.WriteLine("Monthly Debt: " + monthlySum.ToString("C", CultureInfo.CurrentCulture));
        }

    }
}
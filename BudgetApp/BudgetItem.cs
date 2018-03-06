using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BudgetItem : IBudgetItem
    {
        private string name;
        private decimal cost;
        private Cycle cycle;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public decimal Cost
        {
            get { return this.cost; }
            set { this.cost = value; }
        }
        public Cycle Cycle
        {
            get { return this.cycle; }
            set { this.cycle = value; }
        }
    }
}

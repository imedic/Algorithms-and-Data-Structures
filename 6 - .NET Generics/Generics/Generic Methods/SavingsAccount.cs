using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Methods
{
    public class SavingsAccount : Account
    {
        public decimal Interest { get; set; }
        public override decimal Balance
        {
            get { return base.Balance * (1 + Interest / 100); }
        }
        public SavingsAccount(
        string name, decimal balance, decimal interest)
        : base(name, balance)
        {
            Interest = interest;
        }
        public override string ToString()
        {
            return base.ToString() + "|" + Interest + "%";
        }
    }
}

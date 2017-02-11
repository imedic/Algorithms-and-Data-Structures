using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Methods
{
    public class Account : IAccount
    {
        public string Name { get; set; }
        public virtual decimal Balance { get; set; }
        public Account() { }
        public Account(string name, decimal balance)
        {
            Name = name;
            Balance = balance;
        }
        public override string ToString()
        {
            return Name + ":" + Balance;
        }
    }
}

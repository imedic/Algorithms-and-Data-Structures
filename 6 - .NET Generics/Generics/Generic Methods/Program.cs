using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Methods
{
    class Program
    {
        static void Display<T>(List<T> list) where T : IAccount
        {
            // list.Add(new Account("Gea", 500m));

            foreach (var account in list)
                Console.WriteLine(account);
        }

        static decimal Accumulate<T>(IEnumerable<T> collection)
            where T : Account {

            decimal total = 0;
            foreach (var account in collection)
                total += account.Balance;

            return total;
        }

        static void Main(string[] args)
        {
            Account a = new Account("Eva", 100m);
            Account b = new Account("Ida", 200);

            SavingsAccount c =
                new SavingsAccount("Teo", 300m, 5m);

            SavingsAccount d =
                new SavingsAccount("Edo", 400m, 5m);

            Account[] array = { a, b, c };
            List<Account> accounts =
                new List<Account>() { a, b, c, d };
            List<SavingsAccount> savings =
                new List<SavingsAccount>() { c, d };
            
            // savings = accounts;
            // accounts = savings;
            // Display(array);

            Display(accounts);
            Console.WriteLine("----------");
            Display(savings);

            Console.WriteLine("Accumulated Values:");
            decimal total = Accumulate(array);
            Console.WriteLine(total);

            total = Accumulate(accounts);
            Console.WriteLine(total);

            total = Accumulate(savings);
            Console.WriteLine(total);
        }
    }
}

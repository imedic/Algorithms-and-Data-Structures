using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_List
{
    class Program
    {
        static void Main(string[] args)
        {

            List list = new List();
            list.InsertFront("Ivo");
            list.InsertEnd(1);
            list.InsertEnd(3.14);
            list.InsertFront(true);
            list.InsertEnd(100m);

            list.Display();

            try
            {
                list.RemoveEnd();
                list.RemoveFront();
                list.Display();
                list.RemoveEnd();
                list.RemoveFront();
                list.RemoveFront();
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }

            list.Display();
        }
    }
}

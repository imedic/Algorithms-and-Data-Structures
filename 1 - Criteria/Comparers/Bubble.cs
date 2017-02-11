using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparers
{
    class Bubble
    {
        public static void Sort(
            object[] array,
            IComparer comparer)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (comparer.Compare(array[j], array[i]) < 0)
                    {
                        object temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
        }
    }
}

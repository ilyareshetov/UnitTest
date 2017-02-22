using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class ArrayProcessor
    {
        public int[] SortAndFilter(int[] a)
        {
            Array.Sort(a);
            
            List<int> minus = new List<int>();
            List<int> plus = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0) minus.Add(a[i]);
                else plus.Add(a[i]);
            }    

            int[] b = minus.Distinct().Concat(plus).ToArray();

            return b;
        }
    }
}

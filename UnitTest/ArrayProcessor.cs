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
            int[] b;
            b = new int[a.Length];
            int j = 0;
            Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] < 0) && (a[i] == a[i+1]) || (a[i]>=0)) {
                    b[j] = a[i];
                    j++;
                }
            }
            Array.Resize(ref b, j);
            return b;
        }
    }
}

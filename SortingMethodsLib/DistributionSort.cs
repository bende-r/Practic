using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistibutionSortLib
{
    public class DistributionSort
    {
        private double[] _X;

        public DistributionSort(double[] x)
        {
            _X = x;
        }

        public void DistributionSorting()
        {
            ArrayList arrayList = new ArrayList();
            double min;
            int count,length = _X.Length;
            
            while(_X.Length > 0)
            {
                min = _X.Min();
                count = (from num in _X where (num == min) select num).Count();

                for(int i = 0; i < count; i++)
                    arrayList.Add(min);
                
                ArrayWithoutMin();
            }
            Array.Resize(ref _X, arrayList.Count);

            arrayList.CopyTo( _X,0);
        }

        private void ArrayWithoutMin()
        {
            _X = _X.Where(e => e != _X.Min()).ToArray();
        }

        public void ShowArr()
        {
            for (int i = 0; i < _X.Length; i++)
                Console.WriteLine(_X[i]);
        }

    }
}

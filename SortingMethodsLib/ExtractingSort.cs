using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractingSortLib
{
    public class ExtractingSort
    {
        private double[] _X;

        public ExtractingSort(double[] x)
        {
            _X = x;
        }

        public void ExtractSorting()
        {
            for (int i = _X.Length - 1; i > 0; i--)
            {
                int MaxIndex = 0;
                for (int j = 1; j <= i; j++)
                    if (_X[j] > _X[MaxIndex])
                        MaxIndex = j;
                double Tmp = _X[i];
                _X[i] = _X[MaxIndex];
                _X[MaxIndex] = Tmp;
            }
        }
        public void ShowArr()
        {
            for (int i = 0; i < _X.Length; i++)
                Console.WriteLine(_X[i]);
        }
    }
}

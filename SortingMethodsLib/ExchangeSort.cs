using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeSortLib
{
    public class ExchangeSort
    {
        private double[] _X;

        public ExchangeSort(double[] x)
        {
            _X = x;
        }

        public void ExchangeSorting()
        {
            int i, k;
            double T;
            for (k=_X.Length-1; k>0;k--)
            {
                for(i = 0; i < _X.Length-1; i++)
                    if( _X[i] >= _X[i + 1])
                    {
                        T = _X[i];
                        _X[i]= _X[i + 1];
                        _X[i + 1] = T;
                    }
            }
        }
        public void ShowArr()
        {
            for (int i = 0; i < _X.Length; i++)
                Console.WriteLine(_X[i]);
        }
    }
}

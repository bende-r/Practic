using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivationSortLib
{
    public class ActivationSort
    {
        private double[] _X;
        
        public ActivationSort(double[] x)
        {
            _X = x;
        }

        public void ActivationSorting()
        {
            double x = _X.Max();
            double[] arr = new double[_X.Length];
            arr[0] = x;
            for (int i = 1; i < _X.Length; i++)
                if (_X[i] >= arr[i])
                    arr[i] = _X[i];
        }  

        public void ShowArr()
        {
            for (int i = 0; i < _X.Length; i++)
                Console.WriteLine(_X[i]);
        }
    }
}

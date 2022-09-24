using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortLib
{
    public class MergeSort
    {
        private double[] buff;

        public MergeSort(double[] buff)
        {
            this.buff = buff;
        }

        public double[] MergeSorting()
        {
            if (buff.Length > 1)
            {
                double[] left = new double[buff.Length / 2];
                double[] right = new double[buff.Length - left.Length];

                for (int i = 0; i < left.Length; i++)
                    left[i] = buff[i];
                
                for (int i = 0; i < right.Length; i++)
                    right[i] = buff[left.Length + i];
                
                if (left.Length > 1)
                    left = MergeSorting(left);
                if (right.Length > 1)
                    right = MergeSorting(right);

                buff = MergeSorting(left, right);
            }
            return buff;
        }

         private double[] MergeSorting(double[] buff)
        {
            if (buff.Length > 1)
            {
                double[] left = new double[buff.Length / 2];
                double[] right = new double[buff.Length - left.Length];

                for (int i = 0; i < left.Length; i++)
                    left[i] = buff[i];

                for (int i = 0; i < right.Length; i++)
                    right[i] = buff[left.Length + i];

                if (left.Length > 1)
                    left = MergeSorting(left);
                if (right.Length > 1)
                    right = MergeSorting(right);

                buff = MergeSorting(left, right);
            }
            return buff;
        }

        private double[] MergeSorting(double[] left, double[] right)
        {
            
            double[] buff = new double[left.Length + right.Length];
          
            int i = 0;  
            int l = 0; 
            int r = 0;  
                      
            for (; i < buff.Length; i++)
            {
                if (r >= right.Length)
                {
                    buff[i] = left[l];
                    l++;
                }
                else
                {
                    if (l < left.Length && left[l] < right[r])
                    {
                        buff[i] = left[l];
                        l++;
                    }

                    else
                    {
                        buff[i] = right[r];
                        r++;

                    }
                }
            }
            return buff;
        }

        public void ShowArr()
        {
            for (int i = 0; i < buff.Length; i++)
                Console.WriteLine(buff[i]);
        }
    }
}

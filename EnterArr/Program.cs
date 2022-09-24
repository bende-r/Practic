using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ActivationSortLib;
using DistibutionSortLib;
using ExtractingSortLib;
using ExchangeSortLib;
using MergeSortLib;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] x = { 1,2,6,8,2,7,0,-3,0,0.4,2323 };


            ActivationSort activattionSort = new ActivationSort(x);
            DistributionSort distributionSort = new DistributionSort(x);
            ExtractingSort extractingSort = new ExtractingSort(x);
            ExchangeSort exchangeSort = new ExchangeSort(x);
            MergeSort mergeSort = new MergeSort(x);

            activattionSort.ActivationSorting();
            distributionSort.DistributionSorting();
            extractingSort.ExtractSorting();
            exchangeSort.ExchangeSorting();
            mergeSort.MergeSorting();


            activattionSort.ShowArr();
            distributionSort.ShowArr();
            extractingSort.ShowArr();
            exchangeSort.ShowArr();
            mergeSort.ShowArr();

            Console.ReadKey();
        }
    }
}

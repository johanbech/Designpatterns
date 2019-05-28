using System.Collections.Generic;

namespace StrategyPattern
{
    class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort();
            System.Console.WriteLine("QuickSorted list");
        }
    }
}
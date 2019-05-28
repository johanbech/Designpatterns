using System.Collections.Generic;

namespace StrategyPattern
{
    class DescSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Reverse();
            System.Console.WriteLine("descending list");
        }
    }
}
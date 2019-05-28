using System.Collections.Generic;

namespace StrategyPattern
{
    class SortedListed
    {
        List<string> list = new List<string>();
        public SortStrategy SortStrategy;

        public void SetSortedListed(SortStrategy sortStrategy)
        {
            SortStrategy = sortStrategy;
        }

        public void Add(string name)
        {
            list.Add(name);
        }
        public void Sort()
        {
            SortStrategy.Sort(list);

            foreach (var name in list)
            {
                System.Console.WriteLine(" " + name);
            }
        }
        
    }
}
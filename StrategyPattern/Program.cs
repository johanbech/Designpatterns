using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentRecords = new SortedListed();
            studentRecords.Add("Johan");
            studentRecords.Add("Lisbeth");
            studentRecords.Add("Marie");
            studentRecords.Add("Amalie");

            studentRecords.SetSortedListed(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortedListed(new DescSort());
            studentRecords.Sort();

            Console.ReadKey();
        }
    }
}

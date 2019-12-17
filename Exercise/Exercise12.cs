using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Exercise12
    {
        public int SumOfThreeLargestNumbers(int[] numbers)
        {
            List<int> list = numbers.ToList();
            list.Sort();
            list.Reverse();
            return list.ElementAt(0) + list.ElementAt(1) + list.ElementAt(2);
        }
    }
}

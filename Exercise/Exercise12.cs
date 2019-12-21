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
            return numbers.OrderByDescending(x => x).Take(3).Sum();
        }
    }
}

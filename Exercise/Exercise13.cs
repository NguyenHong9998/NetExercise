using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Exercise13
    {
        public int Subtract(List<int> numbers)
        {
            int sumEvenNumbers = numbers.Where(x => x % 2 == 0).Sum();
            int sumNumbersInList = numbers.Sum();
            return 2 * sumEvenNumbers - sumNumbersInList;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Excercise06
    {
        public int SumSequenceOfNumbers(int number)
        {
            var sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += i * (i + 1);
            }
            return sum;
        }
    }
}

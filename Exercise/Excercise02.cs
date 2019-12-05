using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Excercise02
    {
        public int SumDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int num = number % 10;
                sum += num;
                number /= 10;
            }
            return sum;
        }
    }
}

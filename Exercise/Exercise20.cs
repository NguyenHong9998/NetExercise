using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Exercise20
    {
        public int SumSquareNumbers(List<int> numbers)
        {
            return numbers.Where(num => isSquareNumber(num)).Sum();
        }
        public bool isSquareNumber(int number)
        {
            int num = (int)Math.Sqrt(number);
            return num * num == number;
        }
    }
}

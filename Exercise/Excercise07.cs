using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Excercise07
    {
        public int Fact(int number)
        {
            if (number <=1)
            {
                return 1;
            }
            return number * Fact(number - 1);
        }
    }
}

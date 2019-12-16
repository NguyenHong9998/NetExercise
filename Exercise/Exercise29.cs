using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Exercise29
    {
        public bool isBarcodeEAN(string numbers)
        {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    sum += 3*numbers[i];
                }
                else
                {
                    sum += numbers[i];
                }
            }
            return sum % 10 == 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Exercise01
    {
        public int GetGCD(int a, int b)
        {
            while(a * b != 0)
            {
                if(a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            return a + b;
        }

        public int GetLCM(int a, int b)
        {
            return a * b / GetGCD(a, b);
        }
    }
}

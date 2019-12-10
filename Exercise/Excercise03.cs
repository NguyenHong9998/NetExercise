using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Excercise03
    {
        public String DissectNumber(int number)
        {
            List<int> list = new List<int>();
            for (int i = 2; i <= number; i++)
            {
                while (number % i == 0)
                {
                    list.Add(i);
                    number /= i;
                }
            }
            return string.Join("*", list.ToArray());
        }

    }
}

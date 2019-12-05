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
            String result = "";
            for (int i = 2; i <= number; i++)
            {
                while (number % i == 0)
                {
                    list.Add(i);
                    number /= i;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1)
                {
                    result += list.ElementAt(i);
                }
                else
                {
                    result += list.ElementAt(i) + "*";
                }
            }
            return result;
        }

    }
}

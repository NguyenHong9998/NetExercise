using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Exercise11
    {
        public string DuplicateElement(int[] numbers)
        {
            int[] check = new int[numbers.Length];
            List<int> list = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (check[j] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        if (numbers[j] == numbers[i])
                        {
                            list.Add(numbers[j]);
                            check[i] = 1;
                            check[j] = 1;
                        }
                    }

                }
            }
            return string.Join(" ", list.ToArray());
        }
    }
}

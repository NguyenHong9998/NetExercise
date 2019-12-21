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
            List<int> list = new List<int>();
            var temp = numbers.GroupBy(x => x);
            foreach (var group in temp)
            {
                if (group.Count() > 1)
                {
                    list.Add(group.Key);
                }
            }
            return string.Join(" ", list);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Exercise26
    {
        public string CompactString(string stringOfCharacters)
        {
            var result = "";
            var temp = stringOfCharacters.GroupBy(x => x);
            foreach (var itemGroup in temp)
            {
                result += itemGroup.Key ;
                if (itemGroup.Count() != 1)
                {
                    result += itemGroup.Count();
                }
            }
            return result;
        }
    }
}

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
            List<char> letters = stringOfCharacters.ToCharArray().ToList();
            string result = "";
            var temp = letters.GroupBy(x => x);
            foreach (IGrouping<char, char> itemGroup in temp)
            {
                result += itemGroup.Key ;
                if (itemGroup.Count() != 1)
                {
                    result += itemGroup.Count().ToString();
                }
            }
            return result;
        }
    }
}

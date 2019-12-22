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
            if (String.IsNullOrEmpty(stringOfCharacters))
            {
                return "";
            }
            string result = "";
            int start = 0;
            for (int i = 0; i <= stringOfCharacters.Length - 1; i++)
            {
                if (i == stringOfCharacters.Length - 1 || stringOfCharacters.ElementAt(i) != stringOfCharacters.ElementAt(i + 1))
                {
                    int distance = i + 1 - start;
                    if (distance == 1)
                    {
                        result += stringOfCharacters.ElementAt(i).ToString();
                    }
                    else
                    {
                        result += stringOfCharacters.ElementAt(i).ToString() + distance;
                    }
                    start = i + 1;
                }
            }
            return result;
        }
    }
}

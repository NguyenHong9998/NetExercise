using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Exercise27
    {
        public string DeleteTheSameCharacters(string stringOfCharacters)
        {
            if (String.IsNullOrEmpty(stringOfCharacters))
            {
                return "";
            }
            else
            {
                string result = stringOfCharacters.ElementAt(0).ToString();
                for (int i = 1; i < stringOfCharacters.Length; i++)
                {
                    if (stringOfCharacters.ElementAt(i)!= stringOfCharacters.ElementAt(i-1))
                    {
                        result += stringOfCharacters.ElementAt(i).ToString();
                    }
                }
                return result;
            }
           
        }
    }
}

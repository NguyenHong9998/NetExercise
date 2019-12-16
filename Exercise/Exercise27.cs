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
            char[] letters = stringOfCharacters.ToCharArray();
            string result = letters[0].ToString();
            for (int i = 1; i < letters.Length; i++)
            {
                if (letters[i] != letters[i - 1])
                {
                    result += letters[i];
                }
            }
            return result;
        }
    }
}

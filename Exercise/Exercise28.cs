using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Exercise28
    {
        public string TranslateString(string stringOfCharacters)
        {
            var letters = stringOfCharacters.ToCharArray();
            var result = "";
            if (string.IsNullOrEmpty(stringOfCharacters))
            {
                return result;
            }
            var letter="" ;
            int start = 0;
            int end = 0;
            int num = 0;
            for (int i = 0; i < letters.Length; i++)
            {
                if (!char.IsDigit(letters[i]))
                {
                    result += letters[i];
                    letter = letters[i].ToString();
                }
                else
                {
                    start = i;
                    end = i;
                    while (char.IsDigit(letters[end]))
                    {
                        end++;
                    }
                    num = int.Parse(stringOfCharacters.Substring(start, end - start));
                    for (int j = 0; j < num - 1; j++)
                    {
                        result += letter;
                    }
                    i = end - 1;
                }
            }
            return result;
        }
    }
}


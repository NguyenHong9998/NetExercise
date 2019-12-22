using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Exercise22
    {
        public string ToUpperCase(string stringOfCharacters)
        {
            var letters = stringOfCharacters.ToCharArray();
            for(int i = 0; i < letters.Length; i++)
            {
                if (char.IsLower(letters[i]))
                {
                    letters[i] = char.ToUpper(letters[i]);
                }
            }
            return new string(letters);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Exercise21
    {
        public string ToLowerCase(string stringOfCharacters)
        {
            var letters = stringOfCharacters.ToCharArray();
            for (int i = 0; i < stringOfCharacters.Length; i++)
            {
                if (char.IsUpper(letters[i]))
                {
                    letters[i]= char.ToLower(letters[i]);
                }
            }
            return new string(letters);
        }
    }
}

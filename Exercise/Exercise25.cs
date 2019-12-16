using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Exercise25
    {
        public bool IsSymmetry(string stringOfCharacters)
        {
            char[] letters = stringOfCharacters.ToCharArray();
            Array.Reverse(letters);
            string s = new string(letters);
            return stringOfCharacters.Equals(s);
        }
    }
}

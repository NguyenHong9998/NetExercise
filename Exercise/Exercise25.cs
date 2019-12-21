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
            var letters = stringOfCharacters.ToCharArray();
            Array.Reverse(letters);
            return stringOfCharacters.Equals(new string(letters));
        }
    }
}

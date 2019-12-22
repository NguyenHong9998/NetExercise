using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Exercise23
    {
        public string Reverse(string stringOfCharacters)
        {
            var letters = stringOfCharacters.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}

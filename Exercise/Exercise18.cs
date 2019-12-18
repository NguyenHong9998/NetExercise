using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Exercise18
    {
        public int CountNumber(int[] number)
        {
            return number.ToList().Where(x => (x % 3 == 0 && x % 5 != 0)).Count();
        }
    }
}

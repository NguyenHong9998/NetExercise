using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Exercise08
    {
        public float Pi()
        {
            const float E = 0.0001f;
            var s = 0f;
            var e = 1f;
            var n = 0;
            while (e > E)
            {
                e = 1f / (2 * n + 1);
                if (n % 2 == 0)
                    s += e;
                else
                    s -= e;
                n++;
            }
            return 4 * s;
        }
    }
}

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
            float S = 0;
            float e = 1; // sai so e = 1/(2n + 1)
            int n = 0;
            while (e > E)
            {
                e = (float)1 / (2 * n + 1);
                if (n % 2 == 0)
                    S += e;
                else
                    S -= e;
                n++;
            }
            return 4 * S;
        }
    }
}

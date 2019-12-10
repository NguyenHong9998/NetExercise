using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Excercise04
    {
        // Hàm tính số fibonaci thứ n
        public int FibonaciAtN(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            return FibonaciAtN(n - 1) + FibonaciAtN(n - 2);
        }
        //xuất ra danh sách những số fibonaci không lớn hơn n.
        public String PrintFibonaci(int number)
        {
            List<int> list = new List<int>();
            int i = 1;
            while (FibonaciAtN(i) < number)
            {
                list.Add(FibonaciAtN(i));
                i++;
            }
            return string.Join(" ", list.ToArray());
        }
    }
}

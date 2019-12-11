using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Excercise05
    {
        //Viết phương trình giải phương trình bậc 2:
        public String SolvingQuadraticEquation(int a, int b, int c)
        {
            if (a == 0)
            {
                return SuperlativeSolvingEquation(b, c);
            }
            else
            {
                var delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    return "Phuong trinh VN";
                }
                else if (delta == 0)
                {
                    return "Phuong trinh co 1 nghiem x= " + String.Format("{0:0.##}", (-b / (2 * a)));
                }
                else
                {
                    var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    var x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    return "Phuong trinh co 2 nghiem: \n" + "x1= " + String.Format("{0:0.##}", x1) + "\nx2= " + String.Format("{0:0.##}", x2);
                }
            }
        }
        public String SuperlativeSolvingEquation(int a, int b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    return "Phuong trinh VSN";
                }
                else
                {
                    return "Phuong trinh VN";
                }
            }
            else
            {
                return "Phuong trinh co nghiem x= " + String.Format("{0:0.##}", -b / a);
            }
        }
    }
}

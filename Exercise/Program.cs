﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GiaiPTBB(1, 0, -2));
            Console.ReadLine();
        }
        public static String GiaiPTBB(int a, int b, int c)
        {
            String result = "";
            if (a == 0)
            {
                result = GiaiPTBH(b, c);
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    result = "Phuong trinh VN";
                }
                else if (delta == 0)
                {
                    result = "Phuong trinh co 1 nghiem x= " + String.Format("{0:0.##}", (-b / (2 * a)));
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    result = $"x1 = {x1}, x2 = {x2}";
                }
            }
            return result;
        }
        public static String GiaiPTBH(int a, int b)
        {
            String result = "";
            if (a == 0)
            {
                if (b == 0)
                {
                    result = "Phuong trinh VSN";
                }
                else
                {
                    result = "Phuong trinh VN";
                }
            }
            else
            {
                result = "Phuong trinh co nghiem x= " + String.Format("{0:0.##}", -b / a);
            }
            return result;
        }
    }
}

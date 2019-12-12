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
            Console.WriteLine(SumPrime( new List<int> { 2, 3, 4, 5, 6, 7, 8, 9 }));
            Console.ReadLine();
        }
        public static int SumPrime(List<int> numbers)
        {
            return numbers.Where(num => isPrime(num)).Sum();
        }
        public static bool isPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

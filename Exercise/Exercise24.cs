using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Exercise
{
    public class Exercise24
    {
        public int SumOfNumbersInString(string stringOfCharacters)
        {
            var items = Regex.Split(stringOfCharacters, @"\D+");
            int sum = 0;
            foreach (string item in items)
            {
                if (item != "")
                {
                    sum += int.Parse(item);
                }
            }
            return sum;
        }
    }
}

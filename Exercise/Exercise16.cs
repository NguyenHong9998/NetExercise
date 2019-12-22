using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Exercise16
    {
        public void BubbleSort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = a.Length - 1; j > i; j--)
                {
                    if (a[j] < a[i])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        public int BinarySearch(int[] arr, int left, int right, int x)
        {
            if (right >= left)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == x)
                {
                    return mid;
                }
                else if (arr[mid] > x)
                {
                    return BinarySearch(arr, left, mid - 1, x);
                }
                else return BinarySearch(arr, mid + 1, right, x);
            }
            return -1;
        }
    }
}

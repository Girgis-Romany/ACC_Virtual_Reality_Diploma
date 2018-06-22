
// Gerges Romany
// ACC VR Diploma

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Rextester
{
    public class Program
    {
            static int binarySearch(int []arr, int l, int r, int x)
    {
        if (r >= l)
        {
            int mid = l + (r - l)/2;

            if (arr[mid] == x)
                return mid;

            if (arr[mid] > x)
                return binarySearch(arr, l, mid-1, x);  // حاجة شبه اللوب نهايتها وجود الرقم في الناحية اليمين للقسم

            return binarySearch(arr, mid+1, r, x);
        }
        return -1;
    }
        public static void Main(string[] args)
        {
        int []arr = {2, 5, 8, 12, 16, 23, 38, 56, 72, 91};
        int n = arr.Length;   //  n = 10
        int x = 23;

        int result = binarySearch(arr, 0, n-1, x);
// لو مرجعش
// return
// من ال
// mid   or  if
// return -1

// جمل ظهور علي الشاشة بدل ال -1
        if (result == -1)
            Console.WriteLine("Element not present");
        else
            Console.WriteLine("Element found at index " + result);
        }
    }
}

using System;
namespace Binary_Search 
{
    public class Program
    {


    static int[] arr = { 3, 4, 56, 78, 90 };

        static int BSearch(int[] arr, int x)
        {
        int left = 0;
        int right = arr.Length - 1;
        while (left <= right)
            {
            int middle = (left + right) / 2;
            if (arr[middle] == x)
                return middle;

            if (x < arr[middle])
                {
                right = middle - 1;
                }
            else
                {
                left = middle + 1;
                }
            }
        return -1;
        }

    static void Main(string[] args)
        {

        Console.WriteLine(BSearch(arr, 56));

        }
    }
}
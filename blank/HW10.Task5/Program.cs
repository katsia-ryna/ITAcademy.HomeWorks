using System;

namespace HW10.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.codewars.com/kata/563089b9b7be03472d00002b
            /*Define a method/function that removes from a given array of integers
             all the values contained in a second array.*/

            RemoveArray removeArray1 = new RemoveArray(new int[] { 1, 1, 2, 3, 1, 2, 3, 4 }, new int[] { 1, 3 });
            removeArray1.GetNewArray();
            Console.WriteLine();

            RemoveArray removeArray2 = new RemoveArray(new int[] { 1, 1, 2, 3, 1, 2, 3, 4, 4, 3, 5, 6, 7, 2, 8 }, new int[] { 1, 3, 4, 2 });
            removeArray2.GetNewArray();
            Console.WriteLine();

            RemoveArray removeArray3 = new RemoveArray(new int[] { 8, 2, 7, 2, 3, 4, 6, 5, 4, 4, 1, 2, 3 }, new int[] { 2, 4 , 3 });
            removeArray3.GetNewArray();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

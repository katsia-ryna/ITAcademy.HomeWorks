using System;

namespace HW10.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.codewars.com/kata/55b75fcf67e558d3750000a3
            /*Write a class Block that creates a block (Duh..)
             The constructor should take an array as an argument,
             this will contain 3 integers of the form [width, length, height]
             from which the Block should be created.
             */

            Block b = new Block(new int[] {2,2,2});
            b.GetWidth();
            b.GetLength();
            b.GetHeight();
            b.GetVolume();
            b.GetSutfaceArea();
            Console.ReadLine();
        }
    }
}

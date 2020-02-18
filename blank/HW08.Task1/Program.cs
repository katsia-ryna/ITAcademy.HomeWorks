using System;
using System.Text;

namespace HW08.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceString = "1a!2.3!!.. 4.!.?6 7! ..?";
            int indexStr = sourceString.IndexOf('?');
            StringBuilder str1 = new StringBuilder(sourceString.Substring(0, indexStr));
            StringBuilder str2 = new StringBuilder(sourceString.Substring(indexStr));
            for (int i=0; i<str1.Length; i++)
            {
                if (str1[i] == '!' || str1[i] == '.')
                {
                    str1.Remove(i, 1);
                    i--;
                }
            }
            str2.Replace(" ","_") ;
            StringBuilder str3 = str1.Append(str2);
            Console.WriteLine(str3);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HW10.Task5
{
    class RemoveArray
    {
        int[] IntegerList;
        int[] ValuesList;
        public RemoveArray(int[] integerList, int[] valuesList)
        {
            IntegerList = integerList;
            ValuesList = valuesList;
        }

        public int[] GetNewArray()
        {
            for (int i = 0; i < IntegerList.Length; i++)
            {
                for (int j = 0; j < ValuesList.Length; j++)
                {
                    if (IntegerList[i]==ValuesList[j])
                    {
                        Array.Clear(IntegerList,i,1);
                    }
                }
            }
            for (int i = 0; i < IntegerList.Length; i++)
            {
                if (IntegerList[i]!=0)
                {
                    Console.WriteLine($"{IntegerList[i]}");
                }
            }
            return IntegerList;
        }
    }
}

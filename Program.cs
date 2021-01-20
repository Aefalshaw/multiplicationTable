using System;

namespace multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //With the values 1-10, use code to generate a multiplication table
            int[,] mTable = new int[10, 10];
            
            for (int i = 0; i < mTable.GetLength(0); i++)
            {
                for (int j = 0; j < mTable.GetLength(1); j++)
                {
                    mTable[i, j] = (i + 1) * (j + 1);
                    Console.Write("{0,4}", mTable[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapPlacesMinAndMaxElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] doubleArr = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < doubleArr.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArr.GetLength(1); j++)
                {
                    doubleArr[i, j] = random.Next(1, 50 + 1);
                    Console.Write(doubleArr[i, j] + " ");
                }
                Console.WriteLine();
            }
            int Min = doubleArr[0,0], Max = doubleArr[0,1];
            for (int i = 0; i < doubleArr.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArr.GetLength(1); j++)
                {
                    if (doubleArr[i, j] > Max)
                    {
                        Max = doubleArr[i, j];

                    }
                    if (doubleArr[i, j] < Min)
                    {
                        Min = doubleArr[i, j];

                    }
                    Max == Min;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < doubleArr.GetLength(0); i++)
            {
                for (int j = 0; j < doubleArr.GetLength(1); j++)
                {
                    Console.Write(doubleArr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();       
        }         
    }
}

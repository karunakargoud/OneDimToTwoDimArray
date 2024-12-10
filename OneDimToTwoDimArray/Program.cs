using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimToTwoDimArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] oneDimArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12};

            int rows = 3;
            int cols = 4;
            int[,]TwoDimArr= new int [rows, cols];

            int index = 0;
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    TwoDimArr[i,j]=oneDimArr[index++];
                }
            }
            for(int i = 0; i < rows; i++)
            {
                for(int j=0; j < cols; j++)
                {
                    Console.Write(TwoDimArr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
       
    }
}

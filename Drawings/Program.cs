using System;
using System.Collections.Generic;

namespace Drawings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> arrMatrix = new List<List<int>>()
            {
                new List<int>() {1,2,3,4},//n=4
                new List<int>() {4,5,6,7},
                new List<int>() {9,8,9,8},
                new List<int>() {9,8,9,8},
            };

            for (int i = 0; i < arrMatrix.Count; i++)
            {
                for (int j = 0; j < arrMatrix.Count; j++)
                {
                    Console.Write(arrMatrix[i][j]);
                }
                Console.WriteLine("");
            }
        }

    }
}

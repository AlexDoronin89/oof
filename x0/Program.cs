﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x0
{
    class Program
    {
            //1.2 (x0)
        
        static void Main(string[] args)
        {
            int[,] table = new int[10, 10];
            char[,] tableX = new char[10, 10];

            for (int i = 0; i < tableX.GetLength(0); i++)
            {
                for (int j = 0; j < tableX.GetLength(1); j++)
                {
                    if(i<=j)
                    {
                        tableX[i, j] = 'X';
                    }
                    else
                    {
                        tableX[i, j] = ' ';
                    }
                    Console.Write($"{tableX[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}

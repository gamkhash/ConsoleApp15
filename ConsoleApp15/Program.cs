using System.Collections.Generic;
using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;
using static System.Math;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] D = new int[15];
            for (int i = 0; i < D.Length; i++)
                D[i] = int.Parse(ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;
            int c = -1;
            int b = -1;
            for (int i = 0; i < D.Length; i++)  
            {
                if (D[i] > max)
                {
                    max = D[i];
                    c = i;
                }
                if (D[i] < min)
                {
                    min = D[i];
                    b = i;
                }
            }
            int a = D[b];
            D[b] = D[c];
            D[c] = a;
            for (int i = 0; i < D.Length; i++)
                Console.Write(D[i] + " ");
        }
    }
}

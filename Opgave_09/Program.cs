﻿using System;

namespace Opgave_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3, x = 0;

            if (a == 1)
            {
                x = 1;
            }
            if (b == 1)
            {
                x = 2;
            }
            if (c == 3)
            {
                x = 3;
            }
            Console.WriteLine(x);
            x = 0;

            if (a != 1)
            {
                x = 1;
            }
            else if (b == 2)
            {
                x = 2;
            }
            else if (c == 3)
            {
                x = 3;
            }
            Console.WriteLine(x);
            x = 0;

            if (a == 2)
            {
                x = 1;
                if (b == 2)
                {
                    x = 2;
                }
            }
            else if (c == 1)
            {
                x = 3;
            }
            Console.WriteLine(x);
            x = 0;

            if (a - b == b)
            {
                x = 1;
            }
            else
            {
                if(b - a == a)
                {
                    x = 2;
                }
                if (c - b == b)
                {
                    x = 3;
                }
            }
            Console.WriteLine(x);
        }
    }
}

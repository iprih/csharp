﻿using System;

namespace condicional3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            String[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);
            z = int.Parse(vet[2]);

            if (x < y && x < z)
            {
                Console.WriteLine("menor " + x);
            }
            else
            {
                if (y < z)
                {
                    Console.WriteLine("menor " + y);
                }
                else
                {
                    Console.WriteLine("menor " + z);
                }
            }

        }
    }
}

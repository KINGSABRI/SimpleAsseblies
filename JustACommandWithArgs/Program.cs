﻿using System;

namespace JustACommandWithArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine($"Hi {arg}!");
            }
        }
    }
}
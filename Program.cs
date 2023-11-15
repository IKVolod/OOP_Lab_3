using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;
using System.Runtime.CompilerServices;
using OOP_Lab_3;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Виконати задачу 1 чи 2?\nВихід - 0\nВведіть цифру:");

                switch (double.Parse(Console.ReadLine()))
                {
                    case 1: Task1.Start();
                        continue;
                    case 2: Task2.Start();
                        continue;
                    case 0 :
                        return;
                    default: Console.WriteLine("Введіть корректне значення");
                        continue;
                }
            }
        }
    }
}
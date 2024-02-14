using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main (string[] args)
        {
            //вариант 8
            //try
            //{
            //    int m, n, p = 1, s = 0;
            //    Console.WriteLine("Введите размеры массива");
            //    m = int.Parse(Console.ReadLine());
            //    n = int.Parse(Console.ReadLine());
            //    if (n > 0 && m > 0)
            //    {
            //        int[,] mass = new int[n, m];
            //        Console.WriteLine("Введите элементы массива");
            //        for (int i = 0; i < mass.GetLength(0); i++)
            //        {
            //            for (int j = 0; j < mass.GetLength(1); j++)
            //            {
            //                mass[i, j] = int.Parse(Console.ReadLine());
            //                if (j == (mass.GetLength(0) - i - 1) && mass[i, j] < 10)
            //                    p *= mass[i, j];
            //                if (i == j && (mass[i, j] % 10) == 7)
            //                    s += mass[i, j];
            //            }
            //        }
            //        for (int i = 0; i < mass.GetLength(0); i++)
            //        {
            //            for (int j = 0; j < mass.GetLength(1); j++)
            //            {
            //                Console.Write("{0}\t", mass[i, j]);
            //            }
            //            Console.WriteLine("\n");
            //        }
            //        Console.WriteLine($"Произвидение элементов побочной диагонали массива, меньших 10: {p}");
            //        Console.WriteLine($"Сумма элементов главной диагонали массива, оканчивающихся на 7: {s}");
            //    }
            //    else
            //        Console.WriteLine("Высота и ширина массива должны быть больше нуля");
            //}
            //catch { Console.WriteLine("Введен символ"); }
            //Console.ReadKey();
            //вариант 19
            try
            {
                int m, n, p = 1, c = 0, a, b, k1, k2;
                Console.WriteLine("Введите k1 и k2");
                k1 = int.Parse(Console.ReadLine());
                k2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите a и b");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите размеры массива");
                m = int.Parse(Console.ReadLine());
                n = int.Parse(Console.ReadLine());
                if (n > 0 && m > 0)
                {
                    int[,] mass = new int[n, m];
                    Console.WriteLine("Введите элементы массива");
                    for (int i = 0; i < mass.GetLength(0); i++)
                    {
                        for (int j = 0; j < mass.GetLength(1); j++)
                        {
                            mass[i, j] = int.Parse(Console.ReadLine());
                            



                        }
                    }
                    for (int i = 0; i < mass.GetLength(0); i++)
                    {
                        for (int j = 0; j < mass.GetLength(1); j++)
                        {
                            Console.Write("{0}\t", mass[i, j]);
                        }
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine($"Кол-во элементов, кратных {a} и {b}: {p}");
                    Console.WriteLine($"                                         : {c}");
                }
                else
                    Console.WriteLine("Высота и ширина массива должны быть больше нуля");
            }
            catch { Console.WriteLine("Введен символ"); }
            Console.ReadKey();





        }
    }
}

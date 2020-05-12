using System;
using System.Threading;

namespace ConsoleApp13
{
    class Program
    {
        static int[,] Input(out int n, out int m)
        {
            Console.WriteLine("Введите размерность массива: ");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    Random rand = new Random();
                    a[i, j] = rand.Next(-100, 200);
                }
            return a;
        }

        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write("{0,5} ", a[i, j]);
        }

        static void Rezalt(int[,] a)
        {
            int count = 0;
            
            for (int i = 0; i < a.GetLength(0); ++i)
            {   
                bool plus = true;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < 0)
                    {
                        plus = false;
                        break;                      
                    }
                }
                if (plus)
                    count = 1;
            }
            if (count == 1) Console.WriteLine("Строка, состоящая только из положительных элементов есть");
            else Console.WriteLine("Такой строки нет");

        }
        
        static void Main()
        {
            try
            {
                int n, m;
                int[,] myArray = Input(out n, out m);
                Console.WriteLine("Исходный массив:");
                Print(myArray);
                Rezalt(myArray);
            }
            catch { Console.WriteLine("Некорректный ввод!"); }

        }
    }
}

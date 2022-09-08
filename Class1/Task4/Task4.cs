using System;
using System.Numerics;

namespace Task4
{
    public class Task4
    {
/*
 * В решениях следующих заданий предполагается использование циклов.
 */

/*
 * Задание 4.1. Пользуясь циклом for, посимвольно напечатайте рамку размера width x height,
 * состоящую из символов frameChar. Можно считать, что width>=2, height>=2.
 * Например, вызов printFrame(5,3,'+') должен напечатать следующее:

+++++
+   +
+++++
 */
        internal static void PrintFrame(int width, int height, char frameChar = '*')
        {
            char[,] array1;
            array1 = new char[width, height];
            for (int y = 0; y < array1.GetLength(1); y++)
            {
                for (int x = 0; x < array1.GetLength(0); x++)
                {
                    if (y == 0 || x == 0 || y == array1.GetLength(1) - 1 || x == array1.GetLength(0) - 1)
                    {
                        array1[x, y] = frameChar;
                    }
                    else
                    {
                        array1[x, y] = ' ';
                    }
                }
            }
            for (int y = 0; y < array1.GetLength(1); y++)
            {
                for (int x = 0; x < array1.GetLength(0); x++)
                {
                    Console.Write(array1[x, y]);
                }
                Console.Write("\n");
            }
        }
        /*
         * Задание 4.2. Выполните предыдущее задание, пользуясь циклом while.
         */
        internal static void PrintFrame2(int width, int height, char frameChar = '*')
        {
            char[,] array1;
            array1 = new char[width, height];

            int y = 0;
            int x = 0;
            while (y < array1.GetLength(1))
            {
                while (x < array1.GetLength(0))
                {
                    if (y == 0 || x == 0 || y == array1.GetLength(1) - 1 || x == array1.GetLength(0) - 1)
                    {
                        array1[x, y] = frameChar;
                    }
                    else
                    {
                        array1[x, y] = ' ';
                    }
                    x++;
                }
                x = 0;
                y++;
            }

            x = y = 0;
            while (y < array1.GetLength(1))
            {
                while (x < array1.GetLength(0))
                {
                    Console.Write(array1[x, y]);
                    x++;
                }

                Console.Write("\n");
                x = 0;
                y++;
            }
        }


/*
 * Задание 4.3. Даны целые положительные числа A и B. Найти их наибольший общий делитель (НОД),
 * используя алгоритм Евклида:
 * НОД(A, B) = НОД(B, A mod B),    если B ≠ 0;        НОД(A, 0) = A,
 * где «mod» обозначает операцию взятия остатка от деления.
 */
        internal static long Gcd(long a, long b)
        {
            if (a==0)
            {
                return b;
            }
            else
            {
                return Gcd(b % a, a);
            }
        }

/*
 * Задание 4.4. Дано вещественное число X и целое число N (> 0). Найти значение выражения
 * 1 + X + X^2/(2!) + … + X^N/(N!), где N! = 1·2·…·N.
 * Полученное число является приближенным значением функции exp в точке X.
 */
        internal static double ExpTaylor(double x, int n)
        {
            double exp = 1;
            for (int i=1;i<=n;i++)
            {
                double cur = Math.Pow(x,i);
                for (int j=2;j<=i;j++)
                {
                    cur /= j;
                }
                exp += cur;
            }
            return exp;
        }

        public static void Main(string[] args)
        {
            PrintFrame(5, 5, '+');
            Console.Write("\n");
            PrintFrame2(5, 5, '+');
            Console.WriteLine(Gcd(3,8));
            Console.WriteLine(ExpTaylor(1,2));
        }
    }
}
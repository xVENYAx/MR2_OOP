using System;
using System.Linq;

namespace MR2_OOP
{
    internal class ProgramBase
    {
        static void Main(string[] args)
        {

            int n = 9;
            int g = 6;
            int[,] arr = new int[g, n];
            Console.WriteLine("Масив :");
            Random r = new Random();        //заповнюємо матрицю випадковими числами
            for (int i = 0; i < g; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = r.Next(40, 90);    //кожен елемент приймає значення від 40 до 90
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
            var sum = 0.0d;
            var sum1 = 0.0d;
            var sum2 = 0.0d;
            var sum3 = 0.0d;
            var sum4 = 0.0d;
            var sum5 = 0.0d;
            var sum6 = 0.0d;
            var sum7 = 0.0d;
            var sum8 = 0.0d;
            int col = 0; // індекс стовпця по яку вважаємо суму
            int col1 = 1;
            int col2 = 2;
            int col3 = 3;
            int col4 = 4;
            int col5 = 5;
            int col6 = 6;
            int col7 = 7;
            int col8 = 8;


            for (int i = 0; i < g; i++) // Починаємо перебирати рядки
            {
                sum += arr[i, col] / 6;
                sum1 += arr[i, col1] / 6;
                sum2 += arr[i, col2] / 6;
                sum3 += arr[i, col3] / 6;
                sum4 += arr[i, col4] / 6;
                sum5 += arr[i, col5] / 6;
                sum6 += arr[i, col6] / 6;
                sum7 += arr[i, col7] / 6;
                sum8 += arr[i, col8] / 6;
            }
            Console.WriteLine();
            //Виводимо числа
            Console.WriteLine("Значення:");
            Console.WriteLine("Cереднє aрифметичне для 1 стовпця:" + sum);
            Console.WriteLine("Cереднє aрифметичне для 2 стовпця:" + sum1);
            Console.WriteLine("Cереднє aрифметичне для 3 стовпця:" + sum2);
            Console.WriteLine("Cереднє aрифметичне для 4 стовпця:" + sum3);
            Console.WriteLine("Cереднє aрифметичне для 5 стовпця:" + sum4);
            Console.WriteLine("Cереднє aрифметичне для 6 стовпця:" + sum5);
            Console.WriteLine("Cереднє aрифметичне для 7 стовпця:" + sum6);
            Console.WriteLine("Cереднє aрифметичне для 8 стовпця:" + sum7);
            Console.WriteLine("Cереднє aрифметичне для 9 стовпця:" + sum8);

            
        }
    }
}

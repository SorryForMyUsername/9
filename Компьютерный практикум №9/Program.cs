using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум__9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Определить, имеются ли в одномерном массиве
            //случайных чисел элементы, значения которых кратны 11.
            //Вывести такие значения.
            //const int length = 15;
            //int[] omas = new int[length];

            //Random rnd = new Random();

            //for(int i = 0; i < length; i++)
            //{
            //    omas[i] = rnd.Next(1, 100);
            //    Console.WriteLine($"omas[{i}] = {omas[i]}");
            //}

            //Console.WriteLine("Элементы, значения которых кратны 11:");
            //foreach(int el in omas)
            //{
            //    if(el % 11 == 0)
            //    {
            //        Console.WriteLine(el);
            //    }
            //}


            //Задача 2. Найти сумму и количество положительных элементов
            //в одномерном массиве с явной инициализацией.
            //int[] omas = new int[] {3, -4, 8, 9, 0};
            //int sum = 0;
            //int count = 0;

            //foreach(int el in omas)
            //{
            //    if(el > 0)
            //    {
            //        sum += el;
            //        count++;
            //    }
            //}
            //Console.WriteLine($"Сумма: {sum}\tКол-во: {count}");


            //Задача 3. Вывести элементы одномерного массива,
            //заполненного с клавиатуры ,в обратном порядке.
            //const int length = 10;
            //int[] omas = new int[length];

            //for(int i = 0; i < length; i++)
            //{
            //    Console.Write($"omas[{i}] = ");
            //    omas[i] = int.Parse( Console.ReadLine() );
            //}

            //Console.WriteLine("Массив в обратном порядке:");
            //for(int i = length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine($"omas[{i}] = {omas[i]}");
            //}

            Console.ReadKey();
        }
    }
}

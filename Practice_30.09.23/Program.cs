using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Practice_30._09._23
{
    internal class Program
    {
        static int Sum(params int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            // Задание 1 Массив из 20 элементов
            Console.WriteLine("Задание 1 Массив из 20 элементов");
            int[] arr = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next();
            }
            foreach (int i in arr)
                Console.WriteLine(i);
            Patch1:
            try
            {
                Console.WriteLine("Введите первое число, которое хотите поменять местами ");
                int replace1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число, которое хотите поменять местами ");
                int replace2 = int.Parse(Console.ReadLine());
                int index1 = Array.IndexOf(arr, replace1);
                int index2 = Array.IndexOf(arr, replace2);
                arr[index1] = arr[index2];
                arr[index2] = replace1;
                Console.WriteLine("Изменённый массив ");
                foreach (int i in arr)
                    Console.WriteLine(i);
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Вы ввели не существующее в данном массиве число");
                goto Patch1;
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Введите число");
                goto Patch1;
            }
            // Задание 2 Массив, произведение и среднее арифмет.
            Console.WriteLine("Задание 2 Массив, произведение и среднее арифмет.");
            int result = Sum(3, 6, 9, 15, 27);
            int temp = 1;
            int a = 5;
            int[] ints = new int[a];
            ints[0] = 3;
            ints[1] = 6;
            ints[2] = 9;
            ints[3] = 15;
            ints[4] = 27;
            foreach (int i in ints)
                temp *= i;

            Console.WriteLine($"Сумма элементов массива = {result}");
            Console.WriteLine($"Произведение элементов массива = {temp}");
            temp = 0;
            foreach (int i in ints)
                temp += i;
            temp = temp / a;
            Console.WriteLine($"Среднее арифмет. элементов массива = {temp}");
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
     
}

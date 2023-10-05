using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Tumakov_30._09._23
{
    internal class Program
    {
        
        static int Max(int a, int b)
        {
            return Math.Max(a, b);
        }
        static string[] Array(params string[] arr)
        {
            string z, x;
            z = arr[0]; x = arr[1];
            arr[0] = x; arr[1] = z;
            return arr;
            
        }
        static uint Factorial(uint value)
        {
            uint result = 1;
            if (value == 0) 
            {
            return 1;
            }
         
            else
            {
                while (value > 0)
                {
                    result = value * result;
                    value--;
                }
            }
            return result;
        }
        static int Nod(int one, int two)
        {
            int nod = 0;
            while(one != 0 &&  two != 0)
            {
                if(one > two)
                {
                    one = one % two;
                }
                else
                {
                    two = two % one;
                }
            }
            nod = one + two; 
            return nod;

        }
        static int Nod(int one, int two, int three)
        {
           int c = Nod(one, two);
            return Nod(c, three);
        }
        static int FibRec(int p1, int p2, int n)
        {
            return n == 0 ? p1 : FibRec(p2, p1 + p2, n - 1);
        }
        static int Fib(int n) 
        { 
            return FibRec(0, 1, n); 
        }
        static void Main(string[] args)
        {
            // Задание 5.1 Максимальное из чисел
            Console.WriteLine("Задание 5.1 Максимальное из чисел");
        Patch:
            try
            {
                Console.WriteLine("Введите первое число");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Максимальное из чисел - " + Max(a, b));
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Повторите попытку и введите целое число");
                goto Patch;
            }
            // Задание 5.2 Поменять местами 2 параметра
            Console.WriteLine("Задание 5.2 Поменять местами 2 параметра");
            Console.WriteLine("Введите первый параметр");
            string q = Console.ReadLine();
            Console.WriteLine("Введите второй параметр");
            string w = Console.ReadLine();
            Console.WriteLine($"{Array(q, w)[0]}  {Array(q, w)[1]}");
            // Задание 5.3 Факториал числа
            Console.WriteLine("Задание 5.3 Факториал числа");
            Console.WriteLine("Введите целое положительное число");
            Patch1:
            try
            {
                
                    uint factor = uint.Parse(Console.ReadLine());
                    uint result = Factorial(factor);
                if (result == 0)
                {
                    Console.WriteLine("False");
                }
                else
                    Console.WriteLine(result);
                
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Повторите попытку и введите целое число");
                goto Patch1;
            }
            catch(System.OverflowException)
            {
               Console.WriteLine("False");
            }
            // Задание 5.4 Рекурсивный метод выч. факториала
            Console.WriteLine(" Задание 5.4 Рекурсивный метод выч. факториала");
            int Factoriall(int n)
            {
                if (n == 1) return 1;
                return n * Factoriall(n - 1);
            }
            Patch2:
            try
            {
                Console.WriteLine("Введите целое положительное число");
                int factori = int.Parse(Console.ReadLine());
                factori = Factoriall(factori);
                if(factori == 0)
                {
                    Console.WriteLine("Слишком большое число");
                }
                else
                {
                    Console.WriteLine(factori);
                }
                
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Повторите попытку и введите целое число");
                goto Patch2;
            }
            // Д/З 5.1 Алгоритм евклида для 2 чисел
            Console.WriteLine("Д/З 5.1 Алгоритм евклида для 2 чисел");
            Patch3:
            try
            
            {
                Console.WriteLine("Введите первое число");
                int one = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int two = int.Parse(Console.ReadLine());
                Console.WriteLine($"Нод = {Nod(one, two)}");
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Повторите попытку и введите целое число");
                goto Patch3;
            }
            // Д/З 5.1 Алгоритм евклида для 3 чисел
            Console.WriteLine("Д/З 5.1 Алгоритм евклида для 3 чисел");
            Patch4:
            try
            {
                Console.WriteLine("Введите первое число");
                int on = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int tw = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите третье число");
                int thr = int.Parse(Console.ReadLine());
                Console.WriteLine($"Нод = {Nod(on, tw, thr)}");
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Повторите попытку и введите целое число");
                goto Patch4;
            }
            // Д/З 5.2 Число Фибоначчи
            Console.WriteLine("Д/З 5.2 Число Фибоначчи");
            Patch5:
            try
            {
                Console.WriteLine("Введите порядковый номер нужного вам числа Фибоначчи");
                int fibo = int.Parse(Console.ReadLine());
                Console.WriteLine($"Ваше число Фибоначчи с порядковым номером {fibo} имеет значение = {Fib(fibo)}");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Повторите попытку и введите целое число");
                goto Patch5;
            }

            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }
        
    }
}

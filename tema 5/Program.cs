﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1

            //Console.Write("Введите год: ");

            //int year = int.Parse(Console.ReadLine());

            //if(year%4==0)

            //{

            //    Console.WriteLine($"{year} год высокосный");

            //}

            //else

            //{

            //    Console.WriteLine($"{year} год невысокосный");

            //}

            //Console.ReadKey();

            //Задача 2

            //Console.Write("Введите цену: ");

            //int price = int.Parse(Console.ReadLine());

            //if(price>=20000 && price<=30000)

            //{

            //    Console.WriteLine("Цена входит в диапазон ");

            //}

            //else

            //{

            //    Console.WriteLine("Цена не входит в диапазон");

            //}

            //Console.ReadKey();

            //задача 3

            //Console.Write("Введите заданый балл от 0 до 100 ");

            //int b = int.Parse(Console.ReadLine());

            //if(b>=0 && b<=59)

            //{

            //    Console.WriteLine("Неудовлетворительно");

            //}

            //else if(b >= 60 && b <= 74)

            //{

            //    Console.WriteLine("Удовлетворительно");

            //}

            //else if(b >= 75 && b <= 89)

            //{

            //    Console.WriteLine("Хорошо");

            //}

            //else if(b >= 90 && b <= 100)

            //{

            //    Console.WriteLine("Отлично");

            //}

            //else

            //{

            //    Console.WriteLine("Ошибка");

            //}

            //Задача 4

            //Random rnd = new Random();

            //int s = rnd.Next(1,5);

            //switch(s)

            //{

            //    case 1: Console.WriteLine("Красный");

            //        break;

            //    case 2: Console.WriteLine("Желтый");

            //        break;

            //    case 3:Console.WriteLine("Зеленый");

            //        break;

            //    default:Console.Write("Ошибка");

            //        break;

            //}

            //Задача 5

            //Random rnd = new Random();

            //int x = rnd.Next(-100,100);

            //if(x<0 && x/2==0)

            //{

            //    Console.WriteLine($"Число {x} отрицательное и четное");

            //}

            //else if(x < 0 && x / 2 != 0)

            //{

            //    Console.WriteLine($"Число{x} отрицательное и не четное");

            //}

            //else if (x > 0 && x / 2 == 0)

            //{

            //    Console.WriteLine($"Число{x} положительное и четное");

            //}

            //else if (x > 0 && x / 2 != 0)

            //{

            //    Console.WriteLine($"Число{x} положительное и не четное");

            //}

            //Задача 6

            //Console.Write("Введите день недели : ");

            //int s = int.Parse(Console.ReadLine());

            //switch (s)

            //{

            //    case 1:

            //        Console.WriteLine("Понедельник");

            //        break;

            //    case 2:

            //        Console.WriteLine("Вторник");

            //        break;

            //    case 3:

            //        Console.WriteLine("Среда");

            //        break;

            //    case 4:

            //        Console.WriteLine("Четверг");

            //        break;

            //    case 5:

            //        Console.WriteLine("Пятница");

            //        break;

            //    case 6:

            //        Console.WriteLine("Суббота");

            //        break;

            //    case 7:

            //        Console.WriteLine("Воскресенье");

            //        break;

            //    default:

            //        Console.Write("В неделе 7 дней");

            //        break;

            //}

            //Задача 8

            Console.Write("Введите 1 число ");

            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Введите 2 число ");

            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Выберите действие :1 +, 2 -, 3 *, 4 /");

            int act = int.Parse(Console.ReadLine());

            switch (act)

            {

                case 1:

                    Console.WriteLine($"{num1}+{num2}={num1 + num2}");

                    break;



            }
        }
    }
}

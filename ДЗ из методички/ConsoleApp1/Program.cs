using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {//Лабораторная работа 1. Упражнение 2.1 Написать программу, которая спрашивает имя пользователя, и затем приветствует пользователя по имени. (Создать консольное приложение.).
            Console.WriteLine("Лабораторная работа 1. Упражнение 2.1");
            Console.Write("Введите свое имя: ");
            var imya = Console.ReadLine();
            Console.WriteLine($"Привет: {imya}");
         //Упражнение 2.2 Написать программу, которой на вход подается два целых числа, на выходе – результат деления одного числа на другое.Предусмотреть обработку исключительной ситуации, возникающей приделении числа на ноль.
            Console.WriteLine("Лабораторная работа 1. Упражнение 2.2");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            if (y == 0)
            {
                Console.WriteLine("делить на ноль нельзя");
            }
            else
            {
                var r = (double)x / y;
                Console.WriteLine(r);
            }
            //Домашнее задание 2.1 Прочитать букву с экрана и вывести на печать следующую за ней букву в алфавитном порядке.
            Console.WriteLine("Домашнее задание 2.1");
            string bukvi = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяаАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЧШЩЪЬЭЮЯА";
            int n1 = bukvi.IndexOf(Console.ReadLine());
            Console.WriteLine(bukvi[n1 + 1]);
            //Домашнее задание 2.2 Написать программу,которая решает квадратное уравнение.Входные данные – коэффициенты уравнения, выходные –найденные корни.
            Console.WriteLine("Домашнее задание 2.2");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double x1 = (-b - Math.Pow((b*b - 4 * a * c),0.5)) / (2 * a);
            double x2 = (-b + Math.Pow((b*b - 4 * a * c), 0.5)) / (2 * a);
            var y1 = Convert.ToString(x1);
            var y2 = Convert.ToString(x2);
            Console.WriteLine(y1);
            Console.WriteLine(y2);
            Console.ReadKey();
        }
    }
}
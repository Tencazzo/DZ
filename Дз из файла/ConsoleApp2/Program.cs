using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Задания из файла Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
            Console.WriteLine("Файлик задание 1");
            Console.WriteLine(2.7);
            //Задания из файла Вывести на экран числа 50 и 10 одно под другим.
            Console.WriteLine("Файлик задание 2");
            Console.WriteLine(50);
            Console.WriteLine(10);
            //Задания из файла Составить программу вывода на экран «столбиком» четырех любых чисел.
            Console.WriteLine("Файлик задание 3");
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
            //Задания из файла Пользователь вводит число. Выведите на экран число, которое больше введенного на 10.
            Console.WriteLine("Файлик задание 4");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = a1 + 10;
            Console.WriteLine(b1);
            //Задания из файла Дана сторона квадрата. Найти его периметр.
            Console.WriteLine("Файлик задание 5");
            Console.WriteLine("Введите сторону");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double p = a2 * 4;
            Console.WriteLine(p);
            //Задания из файла Дан радиус окружности. Найти длину окружности и площадь круга.
            Console.WriteLine("Файлик задание 6");
            Console.WriteLine("Введите радиус");
            double a3 = Convert.ToDouble(Console.ReadLine());
            double s1 = a3 * 3.1415 * a3;
            double l1 = 2 * a3 * 3.1415;
            Console.WriteLine($"Площадь: {s1}");
            Console.WriteLine($"Длинна: {l1}");
            //Задания из файла Найти значение y=cos(x).
            Console.WriteLine("Файлик задание 7");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double a4 = x1 * (Math.PI / 180);
            double y = Math.Cos(a4);
            Console.WriteLine($"y={y}");
            //Задания из файла Даны основания и высота равнобедренной трапеции. Найти ее периметр.
            Console.WriteLine("Файлик задание 8");
            Console.WriteLine("Основание1:");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Основание2:");
            double b3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Высота:");
            double b4 = Convert.ToDouble(Console.ReadLine());
            double s2 = (b2 + b3) * b4 / 2;
            Console.WriteLine($"Площадь:{s2}");
            //Задания из файла Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.
            Console.WriteLine("Файлик задание 9");
            Console.WriteLine("Цена за кг яблок:");
            double a5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Цена за кг конфет:");
            double a6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Цена за кг печенек:");
            double a7 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("кол-во яблок:");
            double a8 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("кол-во конфет:");
            double a9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("кол-во печенек:");
            double a10 = Convert.ToDouble(Console.ReadLine());
            double a11 = a5 * a8 + a6 * a9 + a7 * a10;
            Console.WriteLine($"Общая цена:{a11}");
            //Задания из файла Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май" .....
            Console.WriteLine("Файлик задание 10");
            Console.WriteLine("Мир Труд Май ");
            Console.WriteLine("Мир");
            Console.WriteLine("        Труд");
            Console.WriteLine("                  Май");
            //Задания из файла Программа просит пользователя ввести 2 числовые переменные. А после она меняет их местами и выводит результат на экран. .....
            Console.WriteLine("Файлик задание 11");
            try
            {
                string s = Console.ReadLine();
                string f = s.Replace(".", ",");
                string[] d = f.Split();
                double a12 = double.Parse(d[0]);
                double a13 = double.Parse(d[1]);
                Console.Write(a13);
                Console.Write($" {a12}");
            }
            catch (FormatException)
            {
                Console.WriteLine("нельзя писать буквы");
            }
            //Задания из файла Программа для подсчета периметра и площади фигур (треугольник,четырехугольник, круг). Пользователь выбирает фигуру, указывает, что программабудет считать – площадь или периметр. .....
            Console.WriteLine("Файлик задание 12");
            Console.WriteLine("Выберите фигуру: трегуольник, четрырехугольник или круг");
            string f1 = Console.ReadLine();
            if (f1 == "треугольник")
            {
                Console.WriteLine("Введите сторону 1");
                double a15 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите сторону 2");
                double a16 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите сторону 3");
                double a17 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Что необходимо посчитать: площадь или периметр?");
                string f2 = Console.ReadLine();
                if (f2 == "площадь")
                {
                    double p4 = a15 + a16 + a17;
                    double p5 = (p4 - a15) * (p4 - a16) * (p4 - a17);
                    double s4 = Math.Pow(p5, 0.5);
                    Console.WriteLine($"{s4}");
                }
                else if (f2 == "периметр")
                {
                    double p4 = a15 + a16 + a17;
                    Console.WriteLine($"{p4}");
                }
            }
            else if (f1 == "четырехугольник")
            {
                Console.WriteLine("Введите сторону");
                double a13 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите сторону 2");
                double a14 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Что необходимо посчитать: площадь или периметр?");
                string f2 = Console.ReadLine();
                if (f2 == "площадь")
                {
                    double s4 = a13 * a14;
                    Console.WriteLine($"{s4}");
                }
                else if (f2 == "периметр")
                {
                    double p4 = (a13 + a14) * 2;
                    Console.WriteLine($"{p4}");
                }
            }
            else if (f1 == "круг")
            {
                Console.WriteLine("Введите радиус");
                double a13 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Что необходимо посчитать: площадь или периметр?");
                string f2 = Console.ReadLine();
                if (f2 == "площадь")
                {
                    double s4 = a13 * 3.1415 * a13;
                    Console.WriteLine($"{s4}");
                }
                else if (f2 == "периметр")
                {
                    double p4 = a13 * 3.1415 * 2;
                    Console.WriteLine($"{p4}");
                }
            }
            else
            {
                Console.WriteLine("введите слово корректно");
            }
            //Задания из файла Составить программу вывода на экран числа, вводимого с клавиатуры. Вводимому числу должно предшествовать сообщение «Вы ввели число».
            Console.WriteLine("Файлик задание 13");
            string a22 = Console.ReadLine();
            Console.WriteLine($"Вы ввели число {a22}");
            //Задания из файла Составить программу вывода на экран следующей информации:
            //2 кг
            //13 17
            Console.WriteLine("Файлик задание 14");
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");
            //Составить программу вывода на экран «столбиком» четырех случайных чисел.
            Console.WriteLine("Файлик задание 15");
            var r = new Random();
            int a24 = r.Next();
            int a18 = r.Next();
            int a19 = r.Next();
            int a20 = r.Next();
            Console.WriteLine(a24);
            Console.WriteLine(a18);
            Console.WriteLine(a19);
            Console.WriteLine(a20);
            //Найти корни квадратного уравнения(коэффициента задаются пользователем с клавиатуры)
            Console.WriteLine("Файлик задание 16");
            Console.WriteLine("Введите коэффициент a");
            double a21 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффициент c");
            double c = Convert.ToDouble(Console.ReadLine());
            double x2 = (-b - Math.Pow((b * b - 4 * a21 * c), 0.5)) / (2 * a21);
            double x3 = (-b + Math.Pow((b * b - 4 * a21 * c), 0.5)) / (2 * a21);
            var y1 = Convert.ToString(x2);
            var y2 = Convert.ToString(x3);
            Console.WriteLine(y1);
            Console.WriteLine(y2);
            //Даны два целых числа. Найти: а) их среднее арифметическое; б) их средне геометрическое.
            Console.WriteLine("Файлик задание 17");
            Console.WriteLine("Введите 1 число");
            double a26 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 2 число");
            double a27 = Convert.ToDouble(Console.ReadLine());
            double sa = (a26 + a27) / 2;
            double sg = Math.Pow((a26 * a27), 0.5);
            Console.WriteLine($"a)Среднее арифметическое {sa}");
            Console.WriteLine($"b)Среднее геометрическое{sg}");
            //Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.
            Console.WriteLine("Файлик задание 18");
            Console.WriteLine("Координаты 1 точки");
            double x5 = Convert.ToDouble(Console.ReadLine());
            double y5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Координаты 2 точки");
            double x6 = Convert.ToDouble(Console.ReadLine());
            double y6 = Convert.ToDouble(Console.ReadLine());
            double f4 = Math.Pow((x5 - x6), 2);
            double f5 = Math.Pow((y5 - y6), 2);
            double r1 = Math.Pow((f4 + f5), 0.5);
            Console.WriteLine(r1);
            //Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.
            Console.WriteLine("Файлик задание 19");
            //Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.
            Console.WriteLine("Файлик задание 20");
            int n = Convert.ToInt32(Console.ReadLine());
            int h1 = n / 3600;
            int h2 = (n - h1 * 3600) / 60;
            int h3 = n % 60;
            Console.WriteLine($"a){h1}");
            Console.WriteLine($"б){h2}");
            Console.WriteLine($"в){h3}");
            //Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.
            Console.WriteLine("Файлик задание 21");
            int h4 = 543 / 130;
            Console.WriteLine(h4);
            //Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.
            Console.WriteLine("Файлик задание 22");
            string str = Console.ReadLine();
            str = str.Substring(2) + str.Substring(0, 2);
            Console.WriteLine(str);
            //Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.
            Console.WriteLine("Файлик задание 23");
            int a28 = Convert.ToInt32(Console.ReadLine());
            int p1 = a28 / 100;
            Console.WriteLine(p1);
            int p2 = a28 / 1000;
            Console.WriteLine(p2);
            //Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.
            Console.WriteLine("Файлик задание 24");
            string n3 = Console.ReadLine();
            string str3 = n3.Substring(3) + n3.Substring(2, n3.Length - 3) + n3.Substring(1, n3.Length - 3) + n3.Substring(0, 1);
            if (str3.Substring(0, 1) == "0")
            {
                str3 = str3.Replace("0", "");
            }
            if (str3.Substring(0, 1) == "0")
            {
                str3 = str3.Replace("0", "");
            }
            if (str3.Substring(0, 1) == "0")
            {
                str3 = str3.Replace("0", "");
            }
            Console.WriteLine(str3);
            string str4 = n3.Substring(1, n3.Length - 3) + n3.Substring(0, 1) + n3.Substring(3) + n3.Substring(2, n3.Length - 3);
            if (str4.Substring(0, 1) == "0")
            {
                str4 = str4.Replace("0", "");
            }
            if (str4.Substring(0, 1) == "0")
            {
                str4 = str4.Replace("0", "");
            }
            if (str4.Substring(0, 1) == "0")
            {
                str4 = str4.Replace("0", "");
            }
            Console.WriteLine(str4);
            string str5 = n3.Substring(0, 1) + n3.Substring(2, n3.Length - 3) + n3.Substring(1, n3.Length - 3) + n3.Substring(3);
            if (str5.Substring(0, 1) == "0")
            {
                str5 = str5.Replace("0", "");
            }
            if (str5.Substring(0, 1) == "0")
            {
                str5 = str5.Replace("0", "");
            }
            if (str5.Substring(0, 1) == "0")
            {
                str5 = str5.Replace("0", "");
            }
            Console.WriteLine(str5);
            string str6 = n3.Substring(2, n3.Length - 3) + n3.Substring(3) + n3.Substring(0, 1) + n3.Substring(1, n3.Length - 3);
            if (str6.Substring(0, 1) == "0")
            {
                str6 = str6.Replace("0", "");
            }
            if (str6.Substring(0, 1) == "0")
            {
                str6 = str6.Replace("0", "");
            }
            if (str6.Substring(0, 1) == "0")
            {
                str6 = str6.Replace("0", "");
            }
            Console.WriteLine(str6);
            //Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили на 10, а к частному слева приписали последнюю цифру числа x, то получилось число n. Найти число x.Значение n вводится с клавиатуры, 100 ≤ n ≤ 999 и при этом число десятков в n не равно нулю.
            Console.WriteLine("Файлик задание 25");
            string n18 = Console.ReadLine();
            int n19 = Convert.ToInt32(n18.Substring(0, 1));
            int n20 = Convert.ToInt32(n18.Substring(1));
            int x = n20 * 10 + n19;
            Console.WriteLine(x);
            //Даны целые числа h, m, s (0 ≤ h ≤ 23, 0 ≤ m ≤ 59, 0 ≤ s ≤ 59), указывающие момент
            //времени: «h часов, m минут, s секунд». Определить угол(в градусах) между
            //положением часовой стрелки в начале суток и в указанный момент времени.
            Console.WriteLine("Файлик задание 26");
            int x15 = Convert.ToInt32(Console.ReadLine());
            int y15 = Convert.ToInt32(Console.ReadLine());
            int z15 = Convert.ToInt32(Console.ReadLine());
            double h7 = 30 * x15 + y15 / 2 + z15 / 120;
            if (h7 > 180)
            {
                Console.WriteLine(360 - h7);
            }
            else
            {
                Console.WriteLine(h7);
            }
            // Часовая стрелка образует угол y с лучом, проходящим через центр и через точку,
            //соответствующую 12 часам на циферблате, 0 ≤ y ≤ 2.Определить значение угла для
            //минутной стрелки, а также количество полных часов и полных минут.
            Console.WriteLine("Файлик задание 27");
            double g3 = Convert.ToDouble(Console.ReadLine());
            double ugl = g3 * 180;                                         
            Console.WriteLine($"Угол мин стрелки {(ugl % 30 * 2) * 6}");   
            Console.WriteLine($"Полные часы:{Convert.ToInt16(ugl / 30)}"); 
            Console.WriteLine($"Полные минуты:{Convert.ToInt16(ugl % 30 * 2)}");
            // Создать программу, которая будет выводить на экран меньшее по модулю из трёх
            //введённых пользователем вещественных чисел
            Console.WriteLine("Файлик задание 28");
            int a31 = Convert.ToInt32(Console.ReadLine());
            int b31 = Convert.ToInt32(Console.ReadLine());
            int c31 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(int.Min(int.Min(int.Abs(a31), int.Abs(b31)), int.Min(int.Abs(b31), int.Abs(c31))));
            //Найти сумму большего и меньшего из трёх заданных чисел
            Console.WriteLine("Файлик задание 29");
            int a32 = Convert.ToInt32(Console.ReadLine());
            int b32 = Convert.ToInt32(Console.ReadLine());
            int c32 = Convert.ToInt32(Console.ReadLine());
            int h32 = int.Min(int.Min(a32, b32), int.Min(b32, c32)) + int.Max(int.Max(a32, b32), int.Max(b32, c32));
            Console.WriteLine(h32);
            //Подсчитать общее количество делителей натурального числа
            Console.WriteLine("Файлик задание 30");
            int a40 = Convert.ToInt32(Console.ReadLine());
            int n15 = 0;
            int k15 = 0;
            while (a40 > n15)
            {
                n15++;
                if (a40 % n15 == 0)
                {
                    k15++;
                }

            }
            Console.WriteLine(k15);
            //31. Вася в школе изучил квадратные уравнения и понял, как они легко решаются путе вычисления дискриминанта. Но Петя поведал ему о методе решения кубических
            //уравнений вида A* X3 +B * X2 + C * X + D = 0.На факультативе по математике Васе задали решить около ста уравнений как раз такого вида.Но, к сожалению, Вася
            //забыл формулы, о которых рассказывал ему Петя. Но Васе было известно, что всe корни уравнений – целые числа и находятся на отрезке[-100, 100]. Поэтому у Васи
            //есть шанс найти их методом перебора, но для этого ему придется затратить уйму времени, т.к.возможно необходимо будет осуществить перебор нескольких тысяч
            //значений.Помогите Васе написать программу, которая поможет ему найти корни кубических уравнений!
            Console.WriteLine("Файлик задание 31");
            double a37 = Convert.ToDouble(Console.ReadLine());
            double b37 = Convert.ToDouble(Console.ReadLine());
            double c37 = Convert.ToDouble(Console.ReadLine());
            double d37 = Convert.ToDouble(Console.ReadLine());
            for (int x37 = -100; x37 <= 100; ++x37)
            {
                if ((a37 * (x37 * x37 * x37) + b37 * (x37 * x37) + c37 * x37 + c37) == 0)
                { Console.WriteLine($"x = {x37}"); }
            }
            //32. Заданы первый и второй элементы арифметической прогрессии. Требуется написать программу, которая вычислит элемент прогрессии по ее номеру.
            Console.WriteLine("Файлик Задание 32");
            Console.WriteLine("Введите первые два элемента ");
            int n32 = Convert.ToInt32(Console.ReadLine());
            int n33 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер элемента ");
            int n34 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n32 + (n33 - n32) * (n34 - 1));
            //33Если я пенсионер или студент и не трудоустроен, то получаю кредит, а если
            //трудоустроен не получаю кредит. Ну а если я, и пенсионер и
            //студент,(трудоустройство тут не имеет значения) то не должен получить.
            //Необходимо вводить строки, содержащие информацию о том, студент, пенсионер
            //или кто-то ещё.Вывести информацию: дадут кредит или нет.
            Console.WriteLine("Файлик Задание 33");
            Console.WriteLine("Вы студент?");
            string l11 = Console.ReadLine();
            bool o1 = true;
            bool o2 = true;
            bool o3 = true;
            if (l11 == "Да") { o1 = true; }
            else { o1 = false; }
            Console.WriteLine("Вы пенсионер?");
            string l2 = Console.ReadLine();
            if (l2 == "Да") { o2 = true; }
            else { o2 = false; }
            Console.WriteLine("Вы трудоустроены?");
            string l3 = Console.ReadLine();
            if (l3 == "Да") { o3 = true; }
            else { o3 = true; }
            if (o1 = o2 = true)
            {
                Console.WriteLine("Кредита не будет");
            }
            else if (o1 = o3 = true)
            {
                Console.WriteLine("Кредита не будет");
            }
            else if (o2 == o3 == true)
            {
                Console.WriteLine("Кредита не будет");
            }
            else if (o2 == o3 == o2 == true)
            {
                Console.WriteLine("Кредита не будет");
            }
            else
            {
                Console.WriteLine("кредит будет");
            }
            //34. Составить программу, которая:а) запрашивает имя человека и повторяет его на экране;б) запрашивает имя человека и повторяет его на экране с приветствием.
            Console.WriteLine("Файлик Задание 34");
            Console.WriteLine("Напишите свое имя");
            Console.WriteLine("a)" + Console.ReadLine());
            Console.WriteLine("Напишите свое имя");
            Console.WriteLine("б)" + "Привет" + Console.ReadLine());
            //35Воспроизвести разговор Гарри и дневника Тома Реддла. Пользователь здоровается с
            //консолью.Консоль спрашивает, как зовут пользователя. Пользователь называет
            //имя.Консоль пишет: привет, < имя пользователя >.После этого пользователь
            //спрашивает, знает ли консоль что-то о тайной комнате.Консоль отвечает «Да».
            //После этого пользователь спрашивает, может ли рассказать. Консоль отвечает
            //«Нет». Спустя 5 секунд консоль дополняет «но могу показать». Консоль меняет
            //цвет на любой случайный цвет.
            Console.WriteLine("Файлик Задание 35");
            Console.ReadLine();
            Console.WriteLine("Как вас зовут?");
            string a41 = Console.ReadLine();
            Console.WriteLine($"Привет, {a41}");
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.ReadLine();
            Console.WriteLine("Нет");
            Thread.Sleep(500);
            Console.WriteLine("но могу показать");
            Console.BackgroundColor = ConsoleColor.Green;
        }
    }
}
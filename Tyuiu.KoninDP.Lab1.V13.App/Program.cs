using Tyuiu.KoninDP.Lab1.V13.Lib;

namespace Tyuiu.KoninDP.Lab1.V13.App
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Лабораторная #1 | Выполнил: Конин Д. П. | МКМб-22-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Лабораторная #1                                                         *");
            Console.WriteLine("* Тема: Расчёты арифметических выражений в C#                             *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Конин Давид Павлович | МКМб-22-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу по методологии TDD на С#, которая запрашивает        *");
            Console.WriteLine("* данные с клавиатуры и вычисляет арифметическое выражение по  вариантам  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                             1 выражение                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*             z = (2*y) + ((2*3*a)/((10*x)-(3*a))) + 2*a                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                             2 выражение                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*  z = 7 + (((a*x)/(2*y))/((3+a)/x))*y - ((2*x)+y+x-(3*a))/(a+x-(8*y))    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            double x, y, a;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение A:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("1 выражение:");
            Console.WriteLine(ds.func1(x, y, a));
            Console.WriteLine("2 выражение:");
            Console.WriteLine(ds.func2(x, y, a));
            Console.ReadKey();
        }
    }
}
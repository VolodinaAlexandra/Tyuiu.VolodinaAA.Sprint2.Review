using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VolodinaAA.Sprint2.Review.V11.Lib;

namespace Tyuiu.VolodinaAA.Sprint2.Review.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт#2 |Выполнила: Володина А.А.|ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#2                                                                *");
            Console.WriteLine("* Тема: Итоговое решение по спринту                                       *");
            Console.WriteLine("* Задание #Review                                                         *");
            Console.WriteLine("* Вариант #13                                                              *");
            Console.WriteLine("* Выполнила: Володина Александра Александровна | ПКТб-23-1                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
            Console.WriteLine("* и вычисляет, находится ли точка в заштрихованной области.               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y;
            Console.WriteLine("Введите координату Х: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y: ");
            y = double.Parse(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res)
            {
                Console.WriteLine($"Точка с координатами ({x},{y}) находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine($"Точка с координатами ({x},{y}) находится вне заштрихованной области");
            }
            Console.ReadKey();
        }
    }
}

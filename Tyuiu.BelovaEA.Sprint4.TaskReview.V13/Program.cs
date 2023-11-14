using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BelovaEA.Sprint4.TaskReview.V13.Lib;

namespace Tyuiu.BelovaEA.Sprint4.TaskReview.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Белова Е. А. | ИИПб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Review                                                            *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Белова Екатерина Андреевна | ИИПб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Дана строка из одноразрядных цифр '159357246'.                          *");
            Console.WriteLine("* Преобразуйте ее в матрицу 3 на 3 и подсчитайте количество чётных чисел. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            string str = "159357246";


            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Строка: {str}");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int index = 0;
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            int res = ds.Calculate(3, 3, str);

            Console.WriteLine($"\nКоличество чётных элементов = {res}");
            Console.ReadKey();
        }
    }
}

using System;
using System.Text;

/*
 * На вход подаются три числа: параметры функции a, b, c
 * Протабулировать функцию y на x \in [1;2] с шагом ∆𝑥 = 0,05
 *
 *      ax^2 + bx + c,              x < 1,2
 * y =  a/x + sqrt(x^2 + 1),        x = 1,2
 *      (a + bx) / sqrt(x^2 + 1),   x > 1,2
 *
 * Пример входных данных:
 * 1
 * 2
 * 3
 *
 * Пример выходных данных:
 * 6
 * 6,203
 * 6,41
 * 6,623
 * 2,395
 * 2,186
 * 2,195
 * 2,202
 * 2,209
 * 2,214
 * 2,219
 * 2,223
 * 2,226
 * 2,229
 * 2,231
 * 2,233
 * 2,234
 * 2,235
 * 2,236
 * 2,236
 * 2,236
 *
 * Примечание: 
 *      При некорректных входных данных вывести сообщение "Ошибка" и завершить выполнение программы.
 *      Вывод чисел необходимо производить с точностью до трех знаков после запятой.
 */

namespace Task3
{
    class Program
    {

        const double step = 0.05;
        const double beginning = 1.0;
        const double end = 2;

        static double Y(double x, double a, double b, double c)
        {
            if (Math.Abs(x - 1.2) < double.Epsilon)
            {
                return a / x + Math.Sqrt(x * x + 1);
            }
            else if (x < 1.2)
            {
                return a * x * x + b * x + c;
            }
            return (a + b * x) / Math.Sqrt(x * x + 1);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double a = 0;
            double b = 0;
            double c = 0;
            for (int i = 0; i < 3; i++)
            {
                if (!double.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Ошибка");
                    return;
                }
                if (i == 0)
                    a = c;
                else if (i == 1)
                    b = c;
            }
            for (double x = beginning; x <= end; x += step)
            {
                Console.WriteLine($"{Y(x, a, b, c):f3}" );
            }
        }
    }
}
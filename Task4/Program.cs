using System;
using System.Text;

/*
 * Вычислить значение выражения 2^𝑁+2^𝑀, 𝑁, 𝑀 – целые неотрицательные числа вводятся пользователем с клавиатуры.
 * Используйте битовые операции для организации «быстрого умножения». Помните о возможности переполнения
 *
 * Пример входных данных:
 * 2
 * 4
 *
 * Пример выходных данных:
 * 20
 *
 * Примечание:
 *      При некорректных входных данных вывести сообщение "Ошибка" и завершить выполнение программы.
 *      При переполнении вывести сообщение "Переполнение".
 */

namespace Task4
{
    class Program
    {
        static int QuickMultiply(int x)
        {
            return 2 << (x - 1);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            if (!int.TryParse(Console.ReadLine(), out int m) && m >= 0)
            {
                Console.WriteLine("Ошибка");
                return;
            }
            if (!int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                Console.WriteLine("Ошибка");
                return;
            }
            int res = QuickMultiply(m) + QuickMultiply(n);
            Console.WriteLine(m < 31 && n < 31 && res == ((long)QuickMultiply(m) + (long)QuickMultiply(n)) ? res.ToString() : "Переполнение");
            Console.ReadLine();
        }
    }
}
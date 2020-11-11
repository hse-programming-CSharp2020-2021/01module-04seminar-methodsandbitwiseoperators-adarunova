using System;
using System.Text;

/*
 * Пользователь последовательно вводит целые числа.
 * Для хранения полученных чисел в программе используется одна переменная.
 * Окончание ввода чисел определяется либо желанием пользователя (ввод строки "q"),
 * либо когда сумма уже введённых отрицательных чисел становится меньше -1000.
 * Определить и вывести на экран среднее арифметическое отрицательных чисел.
 *
 * Пример входных данных:
 *  1
 *  3
 *  -4
 *  2
 *  -3
 *  q
 *
 * Пример выходных данных:
 * -3.5
 *
 * Примечание:
 *      При некорректном вводе вывести сообщение "Ошибка" и завершить выполнение программы.
 *      Разрешается модифицировать предложенные методы и дополнять программу своими при необходимости.
 *      Вывод чисел необходимо производить с точностью до двух знаков после запятой.
 */

namespace Task2
{
    class Program
    {
        // TODO: используйте передачу параметров по ссылке
        static void ReadData(out int sum, out int count)
        {
            sum = 0;
            count = 0;
            do
            {
                string input = Console.ReadLine();
                if (input == "q")
                    break;
                if (!int.TryParse(input, out int number))
                {
                    count = -1;
                    return;
                }
                if (number < 0)
                {
                    sum += number;
                    count++;
                }
            } while (sum >= -1000);
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ReadData(out int sum, out int count);
            Console.WriteLine(count > 0 ? $"{(sum / (double) count):f2}" : count == 0 ? "0" : "Ошибка");
        }
    }
}
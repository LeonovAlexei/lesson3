using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.а) С клавиатуры вводятся числа, пока не будет введен 0(каждое число в новой строке).Требуется подсчитать сумму всех нечетных положительных чисел. 
            //Сами числа и сумму вывести на экран, используя tryParse;
            //б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
            //При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;
            double a;
            string str="\n";
            double sum = 0;
            bool  flag;
            Console.WriteLine("Вводите числа с клавиатуры \nдля подсчета суммы всех нечетных и положительных чисел \nДля окончания ввода введите \"0\"");
            do
            {
                do
                {
                    Console.WriteLine("Введите число");
                    
                    flag = double.TryParse(Console.ReadLine(), out a);
                }
                while (!flag);

                if (a > 0 && a % 2 != 0)
                {
                    sum = sum + a;
                    str = str + a + "\n";
                }
            }
            while (a != 0);
            Console.WriteLine($"Сумаа всех введенных нечетных и положительных чисел будет равна {sum}");
            Console.WriteLine($"Все введенные нечетные и положительные числа: {str}");
            Console.ReadLine();
        }
    }
}

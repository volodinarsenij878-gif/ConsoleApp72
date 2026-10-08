using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program28
{
    class Program
    {
        static bool DangerousCheck(int value)
        {
            Console.WriteLine("Выполняется DangerousCheck — тут будет деление на ноль!");
            return (value / 0 == 1);
        }

        static void Main()
        {
            try
            {
                // & всегда вычисляет обе части → DangerousCheck вызовется и выбросит исключение
                bool res = false & DangerousCheck(10);
                Console.WriteLine($"false & DangerousCheck(10) = {res}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("false & DangerousCheck(10): выброшено DivideByZeroException");
            }
        }
    }
}
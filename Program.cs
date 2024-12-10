using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4ClientConsoleChDynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Динамическое позднее связывание.
            Type typeObj = Type.GetTypeFromProgID("Lb3AutoSvrMyMath.1");
            if (typeObj == null)
            {
                Console.WriteLine("Ошибка получения типа!");
                return;

            }
            Console.WriteLine($"Объект {typeObj.FullName} получен.");

            dynamic objMyMath = Activator.CreateInstance(typeObj);
            if (objMyMath == null)
            {
                Console.WriteLine("Ошибка создания объекта");
                return;
            }

            int num1 = 6;
            int num2 = 3;
            Console.WriteLine($"Операнды: {num1} и {num2}");
            double result1 = objMyMath.Add(num1, num2);
            Console.WriteLine($"Результат выполнения сложения: {result1}");
            double result2 = objMyMath.Mul (num1, num2);
            Console.WriteLine($"Результат выполнения умножения: {result2}");
            double result3 = objMyMath.Div(num1, num2);
            Console.WriteLine($"Результат выполнения деления: {result3}");
            double result4 = objMyMath.Sub(num1, num2);
            Console.WriteLine($"Результат выполнения вычитания: {result4}");
            
        }
    }
}

using System;
using System.Security.Claims;

namespace HW_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m, t;
            bool b;

            Console.WriteLine("Введите количество эелементов одномерного массива");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите способ ввода элементов одномерного массива (1 - вручную, 0 - рандомно)");
            t = int.Parse(Console.ReadLine());
            b = t == 1 ? true : false;
            //OneArray one = new OneArray(n, b);
            BaseArray one_base = new OneArray(n, b);

            Console.WriteLine("Введите размер двумерного массива");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите способ ввода элементов двумерного массива (1 - вручную, 0 - рандомно)");
            t = int.Parse(Console.ReadLine());
            b = t == 1 ? true : false;
            //DoubleArray two = new DoubleArray(n, m, b);
            BaseArray two_base = new DoubleArray(n, m, b);

            Console.WriteLine("Введите количество подмассивов ступенчатого массива");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите способ ввода элементов двумерного массива (1 - вручную, 0 - рандомно)");
            t = int.Parse(Console.ReadLine());
            b = t == 1 ? true : false;
            //StepArray stpe = new StepArray(n, b);
            BaseArray step_base = new StepArray(n, b);

            BaseArray[] arrays = new BaseArray[3] {one_base, two_base, step_base};
            
            foreach(BaseArray i in arrays)
            {
                i.Mid_value();
                i.Output();
            }
            Console.WriteLine();
        }
    }
    
}

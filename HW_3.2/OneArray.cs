using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3._2
{
    public sealed class OneArray : BaseArray
    {
        private static int n;
        private bool b = false;
        public static int[] a;

        public OneArray(int N, bool B)
        {
            n = N;
            b = B;
            a = new int[n];
            if (!b)
            {
                RandFill();
            }
            else
            {
                FillByUser();
            }
        }

        private override void FillByUser()
        {
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        private override void RandFill()
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(1000);
            }
        }

        public override void Output()
        {
            Console.WriteLine("Одномерный массив:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public override void Mid_value()
        {
            Console.WriteLine("Среднее значение элементов одномерного массива:");
            double sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            Console.WriteLine(sum / a.Length);
        }
        
    }
}

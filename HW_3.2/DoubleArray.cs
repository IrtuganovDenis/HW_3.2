using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3._2
{
    public sealed class DoubleArray : BaseArray
    {
        private static int n;
        private static int m;
        private bool b = false;
        public static int[,] a;

        public DoubleArray(int N, int M, bool B)
        {
            n = N;
            b = B;
            m = M;
            a = new int[n, m];
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
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        private override void RandFill()
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rnd.Next(1000);
                }
            }
        }

        public override void Output()
        {
            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public override void Mid_value()
        {
            Console.WriteLine("Среднее значение элементов двумерного массива:");
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum += a[i, j];
                }
            }
            Console.WriteLine(sum / (m * n));
        }
    }
}

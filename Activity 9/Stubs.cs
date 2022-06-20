using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_9
{
    public class Stubs
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public double Avg(double a, double b, double c, double d, double e)
        {
            return (a + b + c + d + e) / 5;
        }

        public int RandSum()
        {
            Random random = new Random();

            return random.Next() + random.Next();
        }

        public bool DivThree(int a, int b, int c)
        {
            if ((a + b + c) % 3 == 0)
                return true;
            else
                return false;
        }

        public string Shorter(string a, string b)
        {
            if (a.Length > b.Length)
                return b;
            else
                return a;
        }

        public double LargestDouble(double[] doubles)
        {
            double biggest = 0;
            for (int i = 0; i < doubles.Length; i++)
                if (biggest < doubles[i])
                    biggest = doubles[i];

            return biggest;
        }

        public int[] RandArray()
        {
            int[] array = new int[50];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next();

            return array;
        }

        public bool And(bool a, bool b)
        {
            if (a == b)
                return true;
            else
                return false;
        }

        public double Product(int a, double b)
        {
            return a * b;
        }

        public double AvgArrays(int[][] a)
        {
            int sum = 0;
            double elements = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    sum += a[i][j];
                    elements++;
                }
            }

            return sum / elements;
        }

    }
}

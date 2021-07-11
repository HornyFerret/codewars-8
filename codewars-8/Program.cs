using System;

namespace codewars_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 8;
            Console.WriteLine(num);
            Console.WriteLine("-----");
            int w = summation(num);
            Console.WriteLine(w);
        }
        public static int summation(int num)
        { 
            int m = 1;
            for (int i = 1; i < num; i++)
            {
                m = m + (i + 1);
            }
            return m;
        }
    }
}

using System;

namespace OOP_lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = -1;

            while (x <= 3)
            {
                double y = Math.Log10(x) / x;

                if (x <= 0.000000000000001) 
                {
                    Console.WriteLine("x = {0,5:f2}, y - не iснує!", x);
                }
                else
                {
                    Console.WriteLine("x = {0,5:f2}, y = {1:f4}", x, y);
                }
                
                x += 0.05;
            }
        }
    }
}

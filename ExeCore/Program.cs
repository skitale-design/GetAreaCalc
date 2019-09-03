using System;

namespace CircleAreaStandardDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure circle = new Figure(new double[] { 10 });
            Console.WriteLine(circle.GetArea());

            Figure triangle = new Figure(new double[] { 1, 2, 3 });
            Console.WriteLine(triangle.GetArea());

            Figure forsides = new Figure(new double[] { 1, 2, 3, 5});

            Console.ReadKey();
        }
    }
}

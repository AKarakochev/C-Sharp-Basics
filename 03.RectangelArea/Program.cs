using System;

namespace _03.RectangelArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());

            int area = sideA * sideB;

            Console.WriteLine(area);
        }
    }
}

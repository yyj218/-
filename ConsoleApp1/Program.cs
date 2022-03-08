using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double z;
            double meal = 100;
            double tip_percent = 0.15;
            double tax_percent = 0.08;
            z = meal * tip_percent + meal * tax_percent + meal;
            Console.Write(z);
        }
    }
}

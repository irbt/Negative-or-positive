//Given a number, write a method that returns number to the power of 2 if negative or square root if positive or zero.
using System;
namespace Program
{
    class NegativeOrPositiveTASK
    {
        public static double NegativeOrPositive(double num)
        {
            return num<0 ? Math.Pow(num,2): Math.Sqrt(num);
        }
        public static void Main()
        {
            Console.WriteLine (NegativeOrPositive(-2));// → 4
            Console.WriteLine (NegativeOrPositive(6.25));// → 2.5

        }

    }
}
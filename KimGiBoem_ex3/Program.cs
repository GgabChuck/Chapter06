using System;

namespace KimGiBoem_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int resultA = 0;

            Plus(a, b, out resultA);

            Console.WriteLine($"{a} + {b} = {resultA}");

            double x = 2.4;
            double y = 3.1;
            double resultB = 0;

            Plus(x, y, out resultB);

            Console.WriteLine($"{x} + {y} = {resultB}");
        }
        public static void Plus(int a, int b, out int c)
        {
            c = a + b;                   
        }
        public static void Plus(double a, double b, out double c) //정수가 아닌 수를 받기 위해 double을 사용하는 Plus 메서드를 추가시킴
        {
            c = a + b;
        }
    }
}

using System;

namespace KimGiBoem_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double mean = 0;

            Mean(1, 2, 3, 4, 5,ref mean); //ref 키워드 사용

            Console.WriteLine("평균 : {0}", mean);
        }
        public static void Mean(double a,double b,double c,double d, double e,ref double mean) //ref 키워드 사용
        {
            mean = (a + b + c + d + e) / 5; // 값에 의한 전달이 아닌 ref 키워드로 참조에 의한 전달로 Mean메소드에 mean이 아닌 Main에 mean으로 전달
        }
    }
}

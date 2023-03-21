using System;

namespace p195_ex2
{
    class MainApp
    {
        public static void Swap(int a, int b, int c)
        {
            int temp = c;
            int temp2 = b;
            b = a;
            c = temp2;
            a = temp;
        }
        static void Main(string[] args)
        {

        }
    }
}

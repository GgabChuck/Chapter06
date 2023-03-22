using System;

namespace RefReturn
{
    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }
        public void Printprice()
        {
            Console.WriteLine($"Price :{price}");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Product carrot = new Product();
            ref int ref_local_price = ref carrot.GetPrice();
            int normal_local_price = carrot.GetPrice();

            carrot.Printprice(); //100
            Console.WriteLine($"Ref Local Price :{ref_local_price}"); //100
            Console.WriteLine($"Normal Local Price :{normal_local_price}"); //100

            ref_local_price = 200;

            carrot.Printprice(); //200
            Console.WriteLine($"Ref Local Price :{ref_local_price}"); //200
            Console.WriteLine($"Normal Local Price :{normal_local_price}"); //100
        }
    }
}

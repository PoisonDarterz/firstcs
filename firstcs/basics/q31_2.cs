using System;

namespace Basics {
    class q31_2 {
        static void xMain(string[] args) {
            Console.Write("Enter price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter discount rate: ");
            double discount = Convert.ToDouble(Console.ReadLine());

            double fprice = price * ((100 - discount) / 100);
            string x = fprice.ToString("#.00");

            Console.WriteLine("The price after discount is RM " + x);
        }
    }
}
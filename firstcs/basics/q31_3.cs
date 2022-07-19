using System;

namespace Basics {
    class q31_3 {
        static double getheight() {
            Console.Write("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            return height;
        }

        static double getwidth() {
            Console.Write("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            return width;
        }

        static double getlength() {
            Console.Write("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            return length;
        }
        
        static void xMain(string[] args) { // main
            double height = getheight();
            double width = getwidth();
            double length = getlength();

            double vol = height * width * length;
            Console.WriteLine("The volume is: " + vol);
        }
    }
}
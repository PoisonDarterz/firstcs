using System;

namespace Basics {
    class q22_2 {
        static void xMain(string[] args) {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double faren = celsius * 9 / 5 + 32;
            Console.WriteLine("Value of temperature in Farenheit is: " + faren + " Fahrenheit");
        }
    }
}
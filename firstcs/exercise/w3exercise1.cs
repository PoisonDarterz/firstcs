using System;

namespace Exercise {
    class w3e1 {
        static void Main(string[] args) {
            //q5
            Console.WriteLine("Input the first number: ");
            int q5a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            int q5b = Convert.ToInt32(Console.ReadLine());

            int temp = q5a;
            q5a = q5b;
            q5b = temp;

            Console.WriteLine("The first number is {0} and the second number is {1} after swapping.\n", q5a, q5b);

            //q6
            Console.WriteLine("Input the first number: ");
            int q6a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            int q6b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number: ");
            int q6c = Convert.ToInt32(Console.ReadLine());

            int q6d = q6a * q6b * q6c;
            Console.WriteLine("{0} x {1} x {2} = {3}\n", q6a, q6b, q6c, q6d);

            //q7
            Console.WriteLine("Input the first number: ");
            int q7a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            int q7b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", q7a, q7b, (q7a + q7b));
            Console.WriteLine("{0} - {1} = {2}", q7a, q7b, (q7a - q7b));
            Console.WriteLine("{0} x {1} = {2}", q7a, q7b, (q7a * q7b));
            Console.WriteLine("{0} / {1} = {2}", q7a, q7b, (q7a / q7b));
            Console.WriteLine("{0} mod {1} = {2}\n", q7a, q7b, (q7a % q7b));

            //q8
            Console.WriteLine("Input a number: ");
            int q8a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine("{0, 2} x {1} = {2}", q8a, i, (q8a * i));
            }
            Console.WriteLine();
        }
    }
}
using System;

namespace Exercise {
    class w3e2 {
        static void Main(string[] args) {
            ////q27
            //Console.WriteLine("Enter a number: ");
            //int q27a = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //while (q27a != 0) {
            //    sum += (q27a % 10);
            //    q27a /= 10;
            //}
            //Console.WriteLine("The sum of the digits is " + sum);
            //Console.WriteLine();

            ////q31
            //int[] q31a = new int[4];
            //int[] q31b = new int[4];
            //int[] q31c = new int[4];
            //for (int i = 0; i < 4; i++) {
            //    Console.WriteLine("Enter a number: ");
            //    q31a[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int j = 0; j < 4; j++) {
            //    Console.WriteLine("Enter a number: ");
            //    q31b[j] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int k = 0; k < 4; k++) {
            //    q31c[k] = q31a[k] * q31b[k];
            //}
            //Console.WriteLine("Array 1: ");
            //for (int l = 0; l < 4; l++) {
            //    Console.Write(q31a[l] + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Array 2: ");
            //for (int m = 0; m < 4; m++) {
            //    Console.Write(q31b[m] + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Multiplied: ");
            //for (int n = 0; n < 4; n++) {
            //    Console.Write(q31c[n] + " ");
            //}
            //Console.WriteLine("\n");

            ////q36
            //Console.WriteLine("Enter first number: ");
            //int q36a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second number: ");
            //int q36b = Convert.ToInt32(Console.ReadLine());
            //bool isrange = false;
            //if ((q36a >= -10 && q36a <= 10) && (q36b >= -10 && q36b <= 10)) {
            //    isrange = true;
            //}
            //Console.WriteLine(isrange);

            //q39
            Console.WriteLine("Enter first number: ");
            int q39a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int q39b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int q39c = Convert.ToInt32(Console.ReadLine());
            int q39min, q39max;
            if((q39a > q39b) && (q39a > q39c)) {
                q39max = q39a;
            } else if (q39b > q39c) {
                q39max = q39b;
            } else {
                q39max = q39c;
            }
            if ((q39a < q39b) && (q39a < q39c)) {
                q39min = q39a;
            } else if (q39b < q39c) {
                q39min = q39b;
            } else {
                q39min = q39c;
            }
            Console.WriteLine("Max number is {0} and min number is {1}.", q39max, q39min);

            //q40
            Console.WriteLine("Enter first number: ");
            int q40a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int q40b = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(20 - q40a) < Math.Abs(20 - q40b)) {
                Console.WriteLine("The closest number is " + q40a);
            } else {
                Console.WriteLine("The closest number is " + q40b);
            }
        }
    }
}
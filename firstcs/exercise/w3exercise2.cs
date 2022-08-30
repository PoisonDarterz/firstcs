using System;

namespace Exercise {
    class w3e2 {
        static void Main(string[] args) {
            //q27
            Console.WriteLine("Enter a number: ");
            int q27a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (q27a != 0) {
                sum += (q27a % 10);
                q27a /= 10;
            }
            Console.WriteLine("The sum of the digits is " + sum);
            Console.WriteLine();

            //q31
            int[] q31a = new int[4];
            int[] q31b = new int[4];
            int[] q31c = new int[4];
            for (int i = 0; i < 4; i++) {
                Console.WriteLine("Enter a number: ");
                q31a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < 4; j++) {
                Console.WriteLine("Enter a number: ");
                q31b[j] = Convert.ToInt32(Console.ReadLine());
            }
            for (int k = 0; k < 4; k++) {
                q31c[k] = q31a[k] * q31b[k];
            }
            Console.WriteLine("Array 1: ");
            for (int l = 0; l < 4; l++) {
                Console.Write(q31a[l] + " ");
            }
        }
    }
}
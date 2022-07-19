using System;

namespace Basics {
    class q22_4 {
        static void xMain(string[] args) {
            int[] array = new int[3];
            int j;
            for (j = 0; j < 3; j++) {
                Console.Write("Input numbers " + (j + 1) + ":");
                array[j] = Convert.ToInt32(Console.ReadLine());
            }

            //calculation of total of 3 numbers, then calculate average
            double total = 0.0;
            for (int i = 0; i < array.Length; i++) {
                total = total + array[i];
            }

            double avg = total / array.Length;

            //output
            Console.WriteLine("The average value is: " + avg);
        }
    }
}
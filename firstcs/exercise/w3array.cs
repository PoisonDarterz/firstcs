using System;
using System.Diagnostics;
using System.Globalization;

namespace Exercise {
    class w3arr {
        static void xMain(string[] args) {
            int[] array1 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
            int sum = 0;
            //q47
            for (int i=0; i<array1.Length; i++) {
                sum += array1[i];
            }
            Console.WriteLine("The sum is " + sum);
            Console.WriteLine();

            //q48
            if ((array1.First() == array1.Last()) && (array1.Length >= 1)) {
                Console.WriteLine("True");
            } else {
                Console.WriteLine("False");
            }
            Console.WriteLine();

            //q50
            Queue<int> q50arr = new Queue<int> (new int[] { 1, 2, 8 });
            int q50a = q50arr.Dequeue();
            q50arr.Enqueue(q50a);
            foreach (int i in q50arr) {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //q51
            int[] q51arr = { 1, 2, 5, 7, 8 };
            int q51h;
            if (q51arr.First() > q51arr.Last()) {
                q51h = q51arr.First();
            } else {
                q51h = q51arr.Last();
            }
            Console.WriteLine("The higher value is: " + q51h);
            Console.WriteLine();

            //q52
            int[] q52arr1 = { 1, 2, 5 };
            int[] q52arr2 = { 0, 3, 8 };
            int[] q52arr3 = { -1, 0, 2 };
            int[] q52arr = { q52arr1[1], q52arr2[1], q52arr3[1] };
            Console.WriteLine("New array: ");
            foreach (int i in q52arr) {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            //q57
            List<int> q57arr = new List<int>();
            Console.WriteLine("Input size of integer: ");
            int q57s = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < q57s; i++) {
                Console.Write("Input a number: ");
                q57arr.Add(Convert.ToInt32(Console.ReadLine()));
            }
            int q57large = -9999999;
            int q57prod;
            for (int j = 0; j < (q57s-1); j++) {
                q57prod = q57arr[j] * q57arr[j + 1];
                if (q57prod > q57large) {
                    q57large = q57prod;
                }
            }
            Console.WriteLine("Array: ");
            foreach (int i in q57arr) {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nThe largest product between adjacent elements: " + q57large);
        }
    }
}
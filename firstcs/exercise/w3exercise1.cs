using System;

namespace Exercise {
    class w3e1 {
        static void xMain(string[] args) {
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

            //q10
            Console.WriteLine("Input the first number: ");
            int q10a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            int q10b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number: ");
            int q10c = Convert.ToInt32(Console.ReadLine());
            int q10d = (q10a + q10b) * q10c;
            int q10e = q10a * q10b + q10b * q10c;

            Console.WriteLine("Result of specified numbers {0}, {1} and {2}, (x+y).z is {3} and x.y + y.z is {4}", q10a, q10b, q10c, q10d, q10e);
            Console.WriteLine();

            //q13
            Console.WriteLine("Input a number: ");
            int q13 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 5; i++) {
                if (i == 0 || i == 4) {
                    Console.WriteLine("{0}{0}{0}", q13);
                } else {
                    Console.WriteLine("{0} {0}", q13);
                }
            }
            Console.WriteLine();

            //q20, q21
            Console.WriteLine("Input the first number: ");
            int q20a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            int q20b = Convert.ToInt32(Console.ReadLine());
            int q20c;
            if (q20a > q20b) {
                q20c = (q20a - q20b) * 2;
            } else {
                q20c = (q20b - q20a);
            }
            Console.WriteLine("The solution for q20 is " + q20c);
            Console.WriteLine();

            int q21 = q20a + q20b;
            if (q21 == 20 || q20a == 20 || q20b == 20) {
                Console.WriteLine("The solution for q21 is true");
            } else {
                Console.WriteLine("The solution for q21 is false");
            }
            Console.WriteLine();

            //q22
            Console.WriteLine("Input a number: ");
            int q22 = Convert.ToInt32(Console.ReadLine());
            if ((q22 >= 80 && q22 <= 100) || (q22 >= 180 && q22 <= 220)) {
                Console.WriteLine("True");
            } else {
                Console.WriteLine("False");
            }
            Console.WriteLine();

            //q26
            bool isPrime;
            int q26sum = 2;
            int q26count = 0;
            for(int i=3; i<=10000; i+=2) {
                isPrime = true;
                for (int j=2; j<=10000; j++) {
                    if (i > j) {
                        if (i % j == 0) {
                            isPrime = false;
                            break;
                        }
                    } else {
                        break;
                    }
                }
                if (isPrime) {
                    q26sum += i;
                    ++q26count;
                }
                if(q26count >= (500-1)) { // -1 because number 2 is excluded from the counter.
                    break;
                }
            }
            Console.WriteLine("Sum is: " + q26sum);
        }
    }
}
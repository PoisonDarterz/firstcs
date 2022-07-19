using System;

namespace Basics {
    class q71_1 {
        static int[] getInput() {
            int[] input = new int[2];
            for (int i = 0; i < 2; i++) {
                Console.Write("Enter a number: ");
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
            return input;
        }
        
        static int getSum(int[] nums) {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++) {
                sum = sum + nums[i];
            }
            return sum;
        }

        static void output(int sum) {
            Console.WriteLine("The sum of the 2 numbers is: " + sum);
        }
        
        static void Main(string[] args) {
            int[] nums = new int[2];
            nums = getInput();
            int sum = getSum(nums);
            output(sum);
        }
    }
}
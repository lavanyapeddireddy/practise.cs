using System;
using System.Collections.Generic;
using System.Text;

namespace MyAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Remove Duplicates from Sorted Array
            Console.WriteLine("Question 1 and Output2:");
            int[] nums1_1 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int numberOfUniqueNumbers1 = RemoveDuplicates(nums1_1);
            Console.WriteLine(numberOfUniqueNumbers1);

            // Example 1.2
            Console.WriteLine("Question 1 and Output1:");
            int[] nums1_2 = { 1, 1, 2 };
            int numberUniqueNumbers1 = RemoveDuplicates(nums1_2);
            Console.WriteLine(numberUniqueNumbers1);


            // Question 2: Move Zeroes
            Console.WriteLine("Question 2 and Output1:");
            int[] nums2_1 = { 0, 1, 0, 3, 12 };
            IList<int> resultAfterMovingZero1 = MoveZeroes(nums2_1);
            string combinationsString1 = ConvertIListToArray(resultAfterMovingZero1);
            Console.WriteLine(combinationsString1);

            // Example 2.2 :
            Console.WriteLine("Question 2 and Output2:");
            int[] nums2_2 = { 0 };
            IList<int> AfterMovingZero1 = MoveZeroes(nums2_2);
            string combinationString1 = ConvertIListToArray(AfterMovingZero1);
            Console.WriteLine(combinationString1);

            // Question 3: 3Sum
            Console.WriteLine("Question 3 and Output1:");
            int[] nums3 = { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> triplets1 = ThreeSum(nums3);
            string tripletResult1 = ConvertIListToNestedList(triplets1);
            Console.WriteLine(tripletResult1);

            // Example 3.2 :
            Console.WriteLine("Question 3 and output2:");
            int[] nums3_1 = { 0, 1, 1 };
            IList<IList<int>> triplet1 = ThreeSum(nums3_1);
            string tripletsResult1 = ConvertIListToNestedList(triplet1);
            Console.WriteLine(tripletsResult1);

            // Example 3.3 :
            Console.WriteLine("Question 3 and Output3:");
            int[] nums3_2 = { 0, 0, 0 };
            IList<IList<int>> triplet2 = ThreeSum(nums3_2);
            string tripletsResult2 = ConvertIListToNestedList(triplet2);
            Console.WriteLine(tripletsResult2);

            // Question 4: Max Consecutive Ones
            Console.WriteLine("Question 4 and Output1:");
            int[] nums4 = { 1, 1, 0, 1, 1, 1 };
            int maxOnes1 = FindMaxConsecutiveOnes(nums4);
            Console.WriteLine(maxOnes1);

            // Example 4.2:
            Console.WriteLine("Question 4 and Output2:");
            int[] nums4_2 = { 1, 0, 1, 1, 0, 1 };
            int maxOne1 = FindMaxConsecutiveOnes(nums4_2);
            Console.WriteLine(maxOne1);

            // Question 5: Binary to Decimal Conversion
            Console.WriteLine("Question 5 and Output1:");
            int binaryInput1 = 101010;
            int decimalResult1 = BinaryToDecimal(binaryInput1);
            Console.WriteLine(decimalResult1);

            // Question 6: Maximum Gap
            Console.WriteLine("Question 6 and Output1:");
            int[] nums5 = { 3, 6, 9, 1 };
            int maxGap1 = MaximumGap(nums5);
            Console.WriteLine(maxGap1);

            // Example 6.2:
            Console.WriteLine("Question 6 and Output2:");
            int[] nums5_1 = { 10 };
            int maxGapp1 = MaximumGap(nums5_1);
            Console.WriteLine(maxGapp1);



            // Question 7: Largest Perimeter Triangle
            Console.WriteLine("Question 7 and Output1:");
            int[] nums6 = { 2, 1, 2 };
            int largestPerimeterResult1 = LargestPerimeter(nums6);
            Console.WriteLine(largestPerimeterResult1);

            // Example 7.2:
            Console.WriteLine("Question 7 and Output2:");
            int[] nums6_2 = { 1, 2, 1, 10 };
            int largestPeriResult1 = LargestPerimeter(nums6_2);
            Console.WriteLine(largestPeriResult1);

            // Question 8: Remove Occurrences of a Substring
            Console.WriteLine("Question 8 and Output1:");
            string result1 = RemoveOccurrences("daabcbaabcbc", "abc");
            Console.WriteLine(result1);

            // Example 8.2:
            Console.WriteLine("Question 8 and Output2:");
            string r1 = RemoveOccurrences("axxxxyyyyb", "xy");
            Console.WriteLine(r1);
        }

        // Question 1: Remove Duplicates from Sorted Array
        // Self-Reflection: As a newcomer to programming, this exercise helped me understand array manipulation and conditional statements better.
        public static int RemoveDuplicates(int[] arr)
        {
            try
            {
                // Check if the array is empty
                if (arr.Length == 0) return 0;

                int index = 0;
                for (int i = 1; i < arr.Length; i++)
                {
                    // If current element is different from previous, increment index and replace value
                    if (arr[i] != arr[index])
                    {
                        index++;
                        arr[index] = arr[i];
                    }
                }
                // Return length of unique numbers
                return index + 1;
            }
            catch (Exception)
            {
                throw;
            }
        }


        // Question 2: Move Zeroes
        // Self-Reflection: This task deepened my understanding of loops, conditional statements, and array manipulation.
        public static IList<int> MoveZeroes(int[] arr)
        {
            try
            {
                // Check if the array is null or empty
                if (arr == null || arr.Length == 0)
                    return new List<int>();

                int zeroCount = 0;

                // Iterate through the array
                for (int i = 0; i < arr.Length; i++)
                {
                    // Count zeroes
                    if (arr[i] == 0)
                    {
                        zeroCount++;
                    }
                    // Move non-zero elements to the left
                    else if (zeroCount > 0)
                    {
                        arr[i - zeroCount] = arr[i];
                        arr[i] = 0;
                    }
                }

                return arr;
            }
            catch (Exception)
            {
                throw;
            }
        }


        // Question 3: 3Sum
        // Self-Reflection: This problem enhanced my understanding of array manipulation, sorting, and nested loops.
        public static IList<IList<int>> ThreeSum(int[] arr)
        {
            Array.Sort(arr);
            List<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (i > 0 && arr[i] == arr[i - 1]) continue;
                int left = i + 1, right = arr.Length - 1;
                while (left < right)
                {
                    int sum = arr[i] + arr[left] + arr[right];
                    if (sum == 0)
                    {
                        result.Add(new List<int> { arr[i], arr[left], arr[right] });
                        while (left < right && arr[left] == arr[left + 1]) left++;
                        while (left < right && arr[right] == arr[right - 1]) right--;
                        left++;
                        right--;
                    }
                    else if (sum < 0)
                        left++;
                    else
                        right--;
                }
            }

            return result;
        }

        // Question 4: Max Consecutive Ones
        // Self-Reflection: This task improved my understanding of loops, conditional statements, and array traversal.
        public static int FindMaxConsecutiveOnes(int[] arr)
        {
            try
            {
                if (arr == null || arr.Length == 0)
                    return 0;

                int maxCount = 0;
                int count = 0;
                foreach (var num in arr)
                {
                    if (num == 1)
                    {
                        count++;
                        maxCount = Math.Max(maxCount, count);
                    }
                    else
                        count = 0;
                }
                return maxCount;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Binary to Decimal Conversion
        // Self-Reflection: This problem deepened my understanding of arithmetic operations and iterative processes.
        public static int BinaryToDecimal(int binary)
        {
            try
            {
                int decimalNumber = 0;
                int baseValue = 1;
                while (binary > 0)
                {
                    int remainder = binary % 10;
                    decimalNumber += remainder * baseValue;
                    binary /= 10;
                    baseValue *= 2;
                }
                return decimalNumber;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Maximum Gap
        // Self-Reflection: This exercise expanded my knowledge of array sorting, traversal, and finding maximum differences.
        public static int MaximumGap(int[] arr)
        {
            try
            {
                if (arr == null || arr.Length < 2)
                    return 0;

                Array.Sort(arr);
                int maxGap = 0;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    maxGap = Math.Max(maxGap, arr[i + 1] - arr[i]);
                }
                return maxGap;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Largest Perimeter Triangle
        // Self-Reflection: This task improved my understanding of loop structures, conditionals, and array sorting.
        public static int LargestPerimeter(int[] arr)
        {
            try
            {
                if (arr == null || arr.Length < 3)
                    return 0;

                Array.Sort(arr);
                for (int i = arr.Length - 1; i >= 2; i--)
                {
                    if (arr[i - 2] + arr[i - 1] > arr[i])
                        return arr[i - 2] + arr[i - 1] + arr[i];
                }
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Remove Occurrences of a Substring
        // Self-Reflection: This exercise enhanced my understanding of string manipulation and iterative processes.
        public static string RemoveOccurrences(string s, string part)
        {
            try
            {
                while (s.Contains(part))
                {
                    int index = s.IndexOf(part);
                    s = s.Remove(index, part.Length);
                }
                return s;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /* Inbuilt Functions - Don't Change the below functions */
        static string ConvertIListToNestedList(IList<IList<int>> input)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("["); // Add the opening square bracket for the outer list

            for (int i = 0; i < input.Count; i++)
            {
                IList<int> innerList = input[i];
                sb.Append("[" + string.Join(",", innerList) + "]");

                // Add a comma unless it's the last inner list
                if (i < input.Count - 1)
                {
                    sb.Append(",");
                }
            }

            sb.Append("]"); // Add the closing square bracket for the outer list

            return sb.ToString();
        }


        static string ConvertIListToArray(IList<int> input)
        {
            // Create an array to hold the strings in input
            string[] strArray = new string[input.Count];

            for (int i = 0; i < input.Count; i++)
            {
                strArray[i] = "" + input[i] + ""; // Enclose each string in double quotes
            }

            // Join the strings in strArray with commas and enclose them in square brackets
            string result = "[" + string.Join(",", strArray) + "]";

            return result;
        }

    }
}

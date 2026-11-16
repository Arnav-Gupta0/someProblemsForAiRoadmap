using Microsoft.Win32.SafeHandles;

namespace someProblemsForAiRoadmap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem 1: Find the largest prime factor of a given number:
            Console.WriteLine("Please enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                while (n % i == 0)
                {
                    n /= i;
                }
            }
            Console.WriteLine("The largest prime factor is: " + n);

            // Problem 2: Find all triplets in an array that sum to 0:
            int[] arr = { -1, 0, 1, 2, 3, -1, -4 };
            Console.WriteLine("Triplets that sum to 0:");
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            Console.WriteLine(arr[i] + ", " + arr[j] + ", " + arr[k]);
                        }
                    }
                }
            }

            //Problem 3: Median of two sorted arrays of different sizes:       // STILL NEEDS TO BE FINISHED
            int[] nums1 = { 1, 5, 7 };
            int[] nums2 = { 2, 3, 9 };
            int[] mergedArray = new int[nums1.Length + nums2.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                mergedArray[i] = nums1[i];
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                mergedArray[i + nums1.Length] = nums2[i];
            }

            for (int i = 0; i < mergedArray.Length - 1; i++)
            {
                int minIndex = i; 

                for (int j = i + 1; j < mergedArray.Length; j++)
                {
                    if (mergedArray[j] < mergedArray[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = mergedArray[i];
                mergedArray[i] = mergedArray[minIndex];
                mergedArray[minIndex] = temp;
            }
            int medianValue = (mergedArray.Length + 1) / 2;
            if (mergedArray.Length % 2 == 1)
            {
                Console.WriteLine($"The Median of the sorted data set is {mergedArray[medianValue]}");
            } 
            else if (mergedArray.Length % 2 == 0)
            {
                double median = (mergedArray[medianValue - 1] + mergedArray[medianValue]) / 2;
                Console.WriteLine($"The Median of the sorted data set is {median}");
            }

            //Problem 4: Pair Sum in a sorted and Rotated Array:
            int[] nums3 = { 11, 15, 6, 8, 9, 10 };
            Console.WriteLine("Please write a target integer");
            int target = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nums3.Length; i++)
            {
                for (int j = i + 1; j < nums3.Length; j++)
                {
                    if (nums3[i] + nums3[j] == target)
                    {
                        Console.WriteLine($"There is a pair {nums3[i]} and {nums3[j]} that sums to the value of {target}");
                    }
                }
            }

            //Problem 5: Missing in arithmetic progression
            int[] nums4 = { 2, 4, 8, 10, 12, 14 };
            int commonDifference = 0;
            int check1 = nums4[1] - nums4[0];
            int check2 = nums4[2] - nums4[1];
            int check3 = nums4[3] - nums4[2];
            if (check1 == check2)
            {
                commonDifference = check1;
            } 
            else if (check1 != check2)
            {
                commonDifference = check3;
            }
            for (int i = 0; i < nums4.Length - 1; i++)
            {
                if (nums4[i] + commonDifference != nums4[i + 1])
                {
                    Console.WriteLine($"In this case, the common differnece is {commonDifference}, and {nums4[i] + commonDifference} is missing between {nums4[i]} and {nums4[i + 1]}");
                }
            }


            /*
            int[] nums1 = { 1, 5, 7 };
            int[] nums2 = { 2, 3, 9 };
            int[] mergedArray = new int[nums1.Length + nums2.Length];
            int smallest = 5;
            for (int i = 0; i < mergedArray.Length; i++)
            {
                for (int j = i; j < nums1.Length; j++)
                {
                    for (int k = i; k < nums2.Length; k++)
                    {
                        if (nums1[j] < nums2[k])
                        {
                            if (smallest > nums1[j])
                            {
                                smallest = nums1[j];
                            }
                        }
                        else if (nums1[j] > nums1[k])
                        {
                            if (smallest > nums2[k])
                            {
                                smallest = nums2[k];
                            }
                        }
                    }
                    mergedArray[i] = smallest;
                    smallest = 100;
                }
            }
            for (int i = 0; i < 6; i ++)
            {
                Console.WriteLine(mergedArray[i]);
            }
            */ // This is all a failed attempt
        }
    }
}
